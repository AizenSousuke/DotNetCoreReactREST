using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DotNetCoreReactREST.Controllers
{
    // TODO: Add authentication
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepo;

        public UsersController(
            IMapper mapper,
            IUserRepository userRepository,
            IPostRepository postRepository,
            ICommentRepository commentRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _userRepo = userRepository;
            _userManager = userManager;
            _signInManager = signInManager;
            _postRepository = postRepository;
            _commentRepository = commentRepository;
        }

        // POST: Api/Users
        [HttpPost]
        public ActionResult<UserDto> CreateUser([FromBody] UserForCreationDto user)
        {
            var userToAdd = _mapper.Map<ApplicationUser>(user);
            _userRepo.AddUser(userToAdd);
            _userRepo.Save();

            var userToReturn = _mapper.Map<UserDto>(userToAdd);
            return CreatedAtRoute("GetUser", new { userId = userToAdd.Id }, userToReturn);
        }

        // DELETE: Api/Users/{UserId}
        [HttpDelete("{userId}")]
        public async Task<ActionResult> DeleteAsync([FromRoute]string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            // Delete comments
            IEnumerable<Comment> commentsToDelete = await _commentRepository.GetCommentsForUser(user.Id);
            foreach (var comment in commentsToDelete)
            {
                _commentRepository.DeleteComment(comment);
            }

            // Delete posts
            // Seems like don't need to add as it does not error out

            // Delete user
            await _userManager.DeleteAsync(user);

            return Ok("Deleted user and all his posts and comments");
        }

        // GET: Api/Users/{UserId}
        [HttpGet("{userId}", Name = "GetUser")]
        public ActionResult<UserDto> Get(string userId)
        {
            var userEntity = _userRepo.GetUserById(userId);
            if (userEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(userEntity));
        }

        // GET: Api/Users/Admins
        [HttpGet("Admins")]
        public ActionResult<IEnumerable<UserDto>> GetAdmins()
        {
            var userEntities = _userRepo.GetAllAdmins();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }

        // GET: Api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            var userEntities = _userRepo.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }

        [HttpGet("login")]
        public IActionResult IsLoggedIn()
        {
            try
            {
                if (_signInManager.IsSignedIn(HttpContext.User))
                {
                    return Ok("User is logged in.");
                }

                return Ok("No user is logged in.");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserForLoginDto user, [FromQuery] bool rememberMe)
        {
            try
            {
                Log.Information("User from method {@User}", user);
                ApplicationUser convertedUser = _mapper.Map<ApplicationUser>(user);
                Log.Information("User from converted user {@User}", convertedUser);
                ApplicationUser userFromManager = await _userManager.FindByEmailAsync(convertedUser.Email);
                Log.Information("User from Manager {@User}", userFromManager);
                if (userFromManager != null)
                {
                    await _signInManager.SignInAsync(userFromManager, new AuthenticationProperties()
                    {
                        IsPersistent = rememberMe ? true : false,
                    });

                    return Ok("Logged in successfully!");
                }
                return Problem("Can't login.");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogOutSync()
        {
            try
            {
                if (_signInManager.IsSignedIn(HttpContext.User))
                {
                    await _signInManager.SignOutAsync();
                    return Ok("Successfully signed out!");
                }

                return Ok("No user is logged in.");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PATCH: Api/User/{UserId}
        [HttpPatch("{userId}")]
        public ActionResult PartiallyUpdateUser(
            string userId,
            JsonPatchDocument<UserForUpdateDto> patchDocument)
        {
            var userFromRepo = _userRepo.GetUserById(userId);
            if (userFromRepo == null)
            {
                return NotFound();
            }

            var userToPatch = _mapper.Map<UserForUpdateDto>(userFromRepo);
            patchDocument.ApplyTo(userToPatch, ModelState);

            if (!TryValidateModel(userToPatch))
            {
                return ValidationProblem(ModelState);
            }

            // Following convention
            _mapper.Map(userToPatch, userFromRepo);
            _userRepo.UpdateUser(userFromRepo);
            _userRepo.Save();

            return NoContent();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserForCreationDto registerModel)
        {
            try
            {
                // Register user
                ApplicationUser user = new ApplicationUser { UserName = registerModel.UserName, Email = registerModel.Email };

                var existingUser = await _userManager.FindByNameAsync(user.UserName);

                if (existingUser != null)
                {
                    return Ok("User " + user.UserName + " already exists!");
                }

                var result = await _userManager.CreateAsync(user, registerModel.PasswordHash);

                if (result.Succeeded)
                {
                    return Ok("Result: " + result + ". User " + registerModel.UserName + " created. You may now log in.");
                }

                return Ok("Didn't succeed to create user. Please try again.");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PUT: Api/User/{UserId}
        [HttpPut("{userId}")]
        public ActionResult UpdateUser(string userId, [FromBody] UserForUpdateDto user)
        {
            var userFromRepo = _userRepo.GetUserById(userId);
            if (userFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(user, userFromRepo);

            _userRepo.UpdateUser(userFromRepo);
            _userRepo.Save();

            return NoContent();
        }

        public override ActionResult ValidationProblem(
            [ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();
            return (ActionResult)options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }
    }
}
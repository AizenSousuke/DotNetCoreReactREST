using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult<UserDto>> CreateUserAsync([FromBody] UserForCreationDto user)
        {
            ApplicationUser userToAdd = _mapper.Map<ApplicationUser>(user);
            ApplicationUser newUser = await _userRepo.AddUserAsync(userToAdd);
            await _userRepo.SaveAsync();
            return Ok(_mapper.Map<UserDto>(newUser));
        }

        // DELETE: Api/Users/{UserId}
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            // Delete comments
            // IEnumerable<Comment> commentsToDelete = await _commentRepository.GetCommentsForUser(user.Id);
            // foreach (var comment in commentsToDelete)
            // {
            //     _commentRepository.DeleteComment(comment);
            // }
            // IEnumerable<Comment> comment = await _commentRepository.GetCommentsForUser(user.Id);

            // Delete posts
            // Seems like don't need to add as it does not error out

            // Delete user
            ApplicationUser deletedUser = await _userRepo.DeleteUserAsync(user);

            return Ok(_mapper.Map<UserDto>(deletedUser).UserName + " has been deleted.");
        }

        // GET: Api/Users/{UserId}
        [HttpGet("{userId}", Name = "GetUser")]
        public async Task<IActionResult> GetAsync(string userId)
        {
            ApplicationUser userEntity = await _userRepo.GetUserByIdAsync(userId);
            if (userEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(userEntity));
        }

        // GET: Api/Users/Admins
        [HttpGet("Admins")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAdminsAsync()
        {
            IEnumerable<ApplicationUser> userEntities = await _userRepo.GetAllAdminsAsync();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }

        // GET: Api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersAsync()
        {
            try
            {
                IEnumerable<ApplicationUser> userEntities = await _userRepo.GetAllUsersAsync();
                return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("login")]
        public IActionResult IsLoggedIn()
        {
            try
            {
                if (_signInManager.IsSignedIn(HttpContext.User))
                {
                    return Ok("User " + HttpContext.User.Identity.Name + " is currently logged in.");
                }

                return Ok("No user is logged in.");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserForLoginDto user, [FromQuery] bool rememberMe = false)
        {
            try
            {
                Log.Information("Remember Me == {@RememberMe}", rememberMe.ToString());
                Log.Information("User's Email from method {@UserEmail}", user.Email);
                ApplicationUser convertedUser = _mapper.Map<ApplicationUser>(user);
                Log.Information("User's Email from converted user {@UserEmail}", convertedUser.Email);
                ApplicationUser userFromManager = await _userManager.FindByEmailAsync(convertedUser.Email);
                Log.Information("User's Name from Manager {@UserName}", userFromManager.NormalizedUserName);

                // Check if user is deleted
                if (userFromManager.IsDeleted)
                {
                    return Unauthorized("User " + userFromManager.UserName + " has been deleted or disabled.");
                }

                if (userFromManager != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult results = await _signInManager.PasswordSignInAsync(userFromManager, user.PasswordHash, rememberMe, false);
                    if (results.Succeeded)
                    {
                        return Ok("Logged in successfully!");
                    }
                    else
                    {
                        return Unauthorized("Check user name or password.");
                    }
                }

                return Problem("Can't login. No user found.");
            }
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }
        }

        // PATCH: Api/User/{UserId}
        [HttpPatch("{userId}")]
        public async Task<IActionResult> PartiallyUpdateUserAsync(
            string userId,
            JsonPatchDocument<UserForUpdateDto> patchDocument)
        {
            ApplicationUser userFromRepo = await _userRepo.GetUserByIdAsync(userId);
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
            // Update actually is at the patchDocument.ApplyTo() method above. This is following convention only.
            _userRepo.UpdateUser(userFromRepo);
            await _userRepo.SaveAsync();
            ApplicationUser updatedUser = await _userRepo.GetUserByIdAsync(userId);

            return Ok(_mapper.Map<UserDto>(updatedUser));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserForCreationDto registerModel)
        {
            try
            {
                // Register user
                ApplicationUser user = new ApplicationUser {
                    UserName = registerModel.UserName,
                    Email = registerModel.Email,
                    NormalizedUserName = registerModel.UserName.Normalize().ToUpper(),
                    NormalizedEmail = registerModel.Email.Normalize().ToUpper(),
                    IsDeleted = false,
                };

                ApplicationUser existingUser = await _userManager.FindByNameAsync(user.UserName);
                ApplicationUser existingUserEmail = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)
                {
                    return BadRequest("User " + user.UserName + " already exists!");
                }

                // Technically the email can be checked at the CreateAsync() method below as it will not return succeeded due to the options in startup.
                if (existingUserEmail != null)
                {
                    return BadRequest("User with Email " + user.Email + " already exists!");
                }

                IdentityResult result = await _userManager.CreateAsync(user, registerModel.PasswordHash);

                if (result.Succeeded)
                {
                    return Ok("Result: " + result + ". User " + registerModel.UserName + " created. You may now log in.");
                }

                return BadRequest("Didn't succeed to create user. Please try again. Make sure you're using a proper password - i.e, P@ssw0rd1.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT: Api/User/{UserId}
        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUserAsync(string userId, [FromBody] UserForUpdateDto user)
        {
            var userFromRepo = await _userRepo.GetUserByIdAsync(userId);
            if (userFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(user, userFromRepo);
            _userRepo.UpdateUser(userFromRepo);
            await _userRepo.SaveAsync();
            ApplicationUser updatedUser = await _userRepo.GetUserByIdAsync(userId);

            return Ok(_mapper.Map<UserDto>(updatedUser));
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
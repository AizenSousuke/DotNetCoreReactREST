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
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST.Controllers
{
    //TODO Add authentication
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsersController(
            IMapper mapper,
            IUserRepository userRepository,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _userRepo = userRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: Api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            var userEntities = _userRepo.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }
        // GET: Api/Users/Admins
        [HttpGet("Admins")]
        public ActionResult<IEnumerable<UserDto>> GetAdmins()
        {
            var userEntities = _userRepo.GetAllAdmins();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }

        // GET api/Users/5
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

        // POST Api/Users
        [HttpPost]
        public ActionResult<UserDto> CreateUser([FromBody]UserForCreationDto user)
        {
            var userToAdd = _mapper.Map<ApplicationUser>(user);
            _userRepo.AddUser(userToAdd);
            _userRepo.Save();

            var userToReturn = _mapper.Map<UserDto>(userToAdd);
            return CreatedAtRoute("GetUser", new { userId = userToAdd.Id }, userToReturn);
        }

        // PUT Api/User/{UserId}
        [HttpPut("{userId}")]
        public ActionResult UpdateUser(string userId, [FromBody]UserForUpdateDto user)
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

        [HttpPatch("{userId}")]
        public ActionResult PartiallyUpdateUser(string userId,
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

            //following convention
            _mapper.Map(userToPatch, userFromRepo);
            _userRepo.UpdateUser(userFromRepo);
            _userRepo.Save();

            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{userId}")]
        public ActionResult Delete(string userId)
        {
            var userFromRepo = _userRepo.GetUserById(userId);
            if (userFromRepo == null)
            {
                return NotFound();
            }
            _userRepo.DeleteUser(userFromRepo);
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
        public async Task<IActionResult> LoginAsync([FromBody] UserForCreationDto user, [FromQuery] bool rememberMe)
        {
            try
            {
                ApplicationUser convertedUser = _mapper.Map<ApplicationUser>(user);
                await _signInManager.SignInAsync(convertedUser, new AuthenticationProperties() {
                    IsPersistent = true
                });
                return Ok("Logged in successfully!");
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

        public override ActionResult ValidationProblem(
            [ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();
            return (ActionResult)options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }
    }
}

using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Helper;
using DotNetCoreReactREST.Repositories;
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
    [Route("api/Users")]
    [ApiController]
    public class UsersController : Controller
    {
        private IMapper _mapper;
        private IUserRepository _userRepo;
        private IUserClassManager _userManager;

        public UsersController(
            IMapper mapper, 
            IUserRepository userRepository,
            IUserClassManager userManager)
        {
            _mapper = mapper;
            _userRepo = userRepository;
            _userManager = userManager;
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
        public ActionResult<UserDto> Post([FromBody]UserForCreationDto user)
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
        // [ValidateAntiForgeryToken]
        public ActionResult RegisterUserAsync([FromBody]UserForCreationDto registerModel)
        {
            try
            {
                if (!_userRepo.UserExistsByName(registerModel.UserName))
                {
                    // Register user
                    // var result = await _userManager.RegisterAsync(new IdentityUser() { UserName = registerModel.UserName, PasswordHash = registerModel.PasswordHash, Email = registerModel.Email }); ;
                    UserManager<IdentityUser> userManager = new UserManager();
                    IdentityUser user = new IdentityUser { UserName = registerModel.UserName };
                    userManager.CreateAsync(user, user.PasswordHash);

                    Post(registerModel);
                    return Ok();

                    // return Ok("Result: " + result + ". User " + registerModel.UserName + " created. You may now log in.");
                }
                return BadRequest("User " + registerModel.UserName + " exists.");
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

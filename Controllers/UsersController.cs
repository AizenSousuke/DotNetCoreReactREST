﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DotNetCoreReactREST.Controllers
{
    // TODO: Add authentication
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly IUserLogic _userLogic;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepo;
        private readonly ILogger<UsersController> _logger;
        private readonly AppSettings _appSettings;

        public UsersController(
            IMapper mapper,
            IUserRepository userRepository,
            IPostRepository postRepository,
            ICommentRepository commentRepository,
            IUserLogic userLogic,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<UsersController> logger,
            IOptions<AppSettings> appSettings)
        {
            _mapper = mapper;
            _userRepo = userRepository;
            _userManager = userManager;
            _signInManager = signInManager;
            _postRepository = postRepository;
            _commentRepository = commentRepository;
            _userLogic = userLogic;
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        // POST: Api/Users
        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUserAsync([FromBody] UserForCreationDto user)
        {
            UserDto createdUser = await _userLogic.AddUserAsync(user);
            if (createdUser == null)
            {
                return BadRequest();
            }

            return Ok(createdUser);
        }

        // DELETE: Api/Users/{UserId}
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]string userId)
        {
            UserDto deletedUser = await _userLogic.DeleteUserAsync(userId);
            if (deletedUser == null)
            {
                return NotFound();
            }

            return Ok(deletedUser);
        }

        // GET: Api/Users/{UserId}
        [HttpGet("{userId}", Name = "GetUser")]
        public async Task<IActionResult> GetAsync(string userId)
        {
            UserDto user = await _userLogic.GetAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // GET: Api/Users/Admins
        [HttpGet("Admins")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllAdminsAsync()
        {
            IEnumerable<UserDto> admins = await _userLogic.GetAllAdminsAsync();
            if (admins == null)
            {
                return NotFound();
            }

            return Ok(admins);
        }

        // GET: Api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersAsync()
        {
            IEnumerable<UserDto> users = await _userLogic.GetUsersAsync();
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpGet("login")]
        public IActionResult IsLoggedIn()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                return Ok("User " + HttpContext.User.Identity.Name + " is currently logged in.");
            }

            return Ok("No user is logged in.");
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] UserForLoginDto user, [FromQuery] bool rememberMe = false)
        {
            _logger.LogInformation("Remember Me == {@RememberMe}", rememberMe.ToString());
            _logger.LogInformation("User's Email from method {@UserEmail}", user.Email);
            ApplicationUser convertedUser = _mapper.Map<ApplicationUser>(user);
            _logger.LogInformation("User's Email from converted user {@UserEmail}", convertedUser.Email);
            ApplicationUser userFromManager = await _userManager.FindByEmailAsync(convertedUser.Email);
            if (userFromManager != null && userFromManager.PasswordHash == user.PasswordHash)
            {
                _logger.LogInformation("User's Name from Manager {@UserName}", userFromManager.NormalizedUserName);

                // Check if user is deleted
                if (userFromManager.IsDeleted)
                {
                    return Unauthorized("User " + userFromManager.UserName + " has been deleted or disabled.");
                }

                // Sign in using Sign In Manager
                //Microsoft.AspNetCore.Identity.SignInResult results = await _signInManager.PasswordSignInAsync(userFromManager, user.PasswordHash, rememberMe, false);
                //if (results.Succeeded)
                //{
                //    return Ok("Logged in successfully!");
                //}
                //else
                //{
                //    return Unauthorized("Check password.");
                //}

                // Sign in and get JWT Token
                user.Token = GenerateJSONWebToken(userFromManager, _appSettings);
                return Ok(_mapper.Map<UserForLoginDto>(user));
            }

            return NotFound("Can't login. No user found. Ensure that you're using the correct email.");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogOutSync()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                await _signInManager.SignOutAsync();
                return Ok("Successfully signed out!");
            }

            return Ok("No user is logged in.");
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
            // Register user
            ApplicationUser user = new ApplicationUser
            {
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

        private string GenerateJSONWebToken(ApplicationUser user, AppSettings appSettings) {

#pragma warning disable SA1312 // Variable names should begin with lower-case letter
            SecurityToken JSONWebToken;
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
            byte[] secretKey = Encoding.ASCII.GetBytes(appSettings.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer = appSettings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature),
            };
            JSONWebToken = tokenHandler.CreateToken(tokenDescriptor);
            string token = tokenHandler.WriteToken(JSONWebToken);
            return token;
        }
    }
}
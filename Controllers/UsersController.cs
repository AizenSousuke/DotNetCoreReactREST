using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Models;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST.Controllers
{
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IMapper _mapper;
        private IUserRepository _userRepo;

        public UsersController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepo = userRepository;
        }
        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>>GetUsers()
        {
            var userEntities = _userRepo.GetUsers();
            if(userEntities == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<UserDto>>(userEntities));
        }

        // GET api/Users/5
        [HttpGet("{userId}", Name ="GetUser")]
        public ActionResult<UserDto> Get(string userId)
        {
            var userEntity = _userRepo.GetUserById(userId);
            if(userEntity == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<UserDto>(userEntity));
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody]UserForCreationDto user)
        {
            //TODO Add Authentication
        }

        // PUT api/<controller>/5
        [HttpPut("{userId}")]
        public ActionResult Put(string userId, [FromBody]UserForUpdateDto user)
        {
            var userFromRepo = _userRepo.GetUserById(userId);
            if(userFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(user, userFromRepo);
            //is same code as this 
            //var userToUpdate = _mapper.Map<UserForUpdateDto>(userFromRepo);
            //userToUpdate = user;
            //var updatedUser = _mapper.Map<ApplicationUser>(userToUpdate);
            
            _userRepo.UpdateUser(userFromRepo);
            _userRepo.Save();

            return NoContent();

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

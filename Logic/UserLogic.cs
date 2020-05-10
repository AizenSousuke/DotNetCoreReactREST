using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Identity;

namespace DotNetCoreReactREST.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepo;

        public UserLogic(
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

        public async Task<UserDto> AddUserAsync(UserForCreationDto user)
        {
            ApplicationUser userToAdd = _mapper.Map<ApplicationUser>(user);
            ApplicationUser newUser = await _userRepo.AddUserAsync(userToAdd);
            bool isSaved = await _userRepo.SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            return _mapper.Map<UserDto>(newUser);
        }

        public async Task<UserDto> DeleteUserAsync(string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return null;
            }

            // Delete comments

            // Delete posts

            // Delete user
            ApplicationUser deletedUser = await _userRepo.DeleteUserAsync(user);
            if (deletedUser == null)
            {
                return null;
            }

            return _mapper.Map<UserDto>(deletedUser);
        }

        public async Task<UserDto> GetAsync(string userId)
        {
            ApplicationUser userEntity = await _userRepo.GetUserByIdAsync(userId);
            if (userEntity == null)
            {
                return null;
            }

            return _mapper.Map<UserDto>(userEntity);
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            IEnumerable<ApplicationUser> userEntities = await _userRepo.GetAllUsersAsync();
            return _mapper.Map<IEnumerable<UserDto>>(userEntities);
        }

        public async Task<IEnumerable<UserDto>> GetAllAdminsAsync()
        {
            IEnumerable<ApplicationUser> userEntities = await _userRepo.GetAllAdminsAsync();
            if (userEntities == null)
            {
                return null;
            }

            return _mapper.Map<IEnumerable<UserDto>>(userEntities);
        }
    }
}

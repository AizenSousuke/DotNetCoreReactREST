using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReactREST.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ApplicationUser> AddUserAsync(ApplicationUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.DateCreated = DateTime.Now;
            await _context.Users.AddAsync(user);
            ApplicationUser newUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            return await GetUserByIdAsync(newUser.Id);
        }

        public async Task<ApplicationUser> DeleteUserAsync(ApplicationUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            ApplicationUser userToDelete = await GetUserByIdAsync(user.Id);
            userToDelete.IsDeleted = !userToDelete.IsDeleted;
            await SaveAsync();
            return await GetUserByIdAsync(user.Id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllAdminsAsync()
        {
            return await _context.Users
                .Where(u => u.IsAdmin == true)
                .OrderBy(u => u.UserName)
                .ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users
                .OrderBy(u => u.UserName)
                .ToListAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public void UpdateUser(ApplicationUser user)
        {
            // No code needed here using ef core.
            // Call to this method is just in line with loose coupling and persistance agnostic
        }

        public bool UserExists(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return _context.Users.Any(u => u.Id == userId);
        }

        public bool UserExistsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            return _context.Users.Any(u => u.UserName == name);
        }
    }
}
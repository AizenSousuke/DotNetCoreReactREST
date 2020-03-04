using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public UserRepository(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }
        public void AddUser(ApplicationUser user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            var tempPassword = "P@ssw0rd!" + Guid.NewGuid().ToString();
            user.PasswordHash = tempPassword;
            _context.Users.Add(user);
        }

        public void DeleteUser(ApplicationUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            _context.Users.Remove(user);
        }

        public ApplicationUser GetUserById(string userId)
        {
            if (String.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }
            return _context.Users.FirstOrDefault(u => u.Id == userId);
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users.OrderBy(u => u.IsAdmin)
                .OrderBy(u => u.UserName).ToList();
        }
        public async Task<IdentityResult> SaveUser(ApplicationUser user)
        {
            return await _userManager.UpdateAsync(user);
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(ApplicationUser user)
        {
            //no code needed here using ef core. 
            //Call to this method is just in line with 
            //loose coupling and persistance agnostic
        }

        public bool UserExists(string userId)
        {
            if (String.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return _context.Users.Any(u => u.Id == userId);
        }
    }
}

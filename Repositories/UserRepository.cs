using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCoreReactREST.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddUser(ApplicationUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }            
            user.DateCreated = DateTime.Now;
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
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _context.Users.
                OrderBy(u => u.UserName)
                .ToList();
        }
        public IEnumerable<ApplicationUser> GetAllAdmins()
        {
            return _context.Users
                .Where(u => u.IsAdmin == true)
                .OrderBy(u => u.UserName)
                .ToList();
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

        public bool UserExistsByName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            return _context.Users.Any(u => u.UserName == name);
        }
    }
}

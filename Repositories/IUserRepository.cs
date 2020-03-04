using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<ApplicationUser> GetUsers();
        public ApplicationUser GetUserById(string userId);
        public void AddUser(ApplicationUser user);
        public void UpdateUser(ApplicationUser user);
        public void DeleteUser(string userId);
        public bool UserExists(string userId);
        public bool Save();
    }
}

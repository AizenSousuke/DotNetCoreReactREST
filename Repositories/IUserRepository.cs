using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<ApplicationUser> GetAllUsers();
        public IEnumerable<ApplicationUser> GetAllAdmins();       
        public ApplicationUser GetUserById(string userId);
        public void AddUser(ApplicationUser user);
        public void UpdateUser(ApplicationUser user);
        public void DeleteUser(ApplicationUser user);
        public bool UserExists(string userId);
        public bool Save();
        
    }
}

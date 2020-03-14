using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        IEnumerable<ApplicationUser> GetAllAdmins();
        ApplicationUser GetUserById(string userId);
        void AddUser(ApplicationUser user);
        void UpdateUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
        bool UserExists(string userId);
        bool UserExistsByName(string userName);
        bool Save();
    }
}

using System.Collections.Generic;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface IUserRepository
    {
        void AddUser(ApplicationUser user);

        void DeleteUser(ApplicationUser user);

        IEnumerable<ApplicationUser> GetAllAdmins();

        IEnumerable<ApplicationUser> GetAllUsers();

        ApplicationUser GetUserById(string userId);

        bool Save();

        void UpdateUser(ApplicationUser user);

        bool UserExists(string userId);

        bool UserExistsByName(string userName);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface IUserRepository
    {
        Task<ApplicationUser> AddUserAsync(ApplicationUser user);

        Task<ApplicationUser> DeleteUserAsync(ApplicationUser user);

        Task<IEnumerable<ApplicationUser>> GetAllAdminsAsync();

        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();

        Task<ApplicationUser> GetUserByIdAsync(string userId);

        Task<bool> SaveAsync();

        void UpdateUser(ApplicationUser user);

        bool UserExists(string userId);

        bool UserExistsByName(string name);
    }
}
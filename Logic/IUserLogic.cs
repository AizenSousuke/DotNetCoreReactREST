using DotNetCoreReactREST.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Logic
{
    public interface IUserLogic
    {
        Task<UserDto> AddUserAsync(UserForCreationDto user);

        Task<UserDto> DeleteUserAsync(string userId);

        Task<UserDto> GetAsync(string userId);

        Task<IEnumerable<UserDto>> GetUsersAsync();
    }
}
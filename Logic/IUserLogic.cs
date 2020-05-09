using DotNetCoreReactREST.Dtos;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Logic
{
    public interface IUserLogic
    {
        Task<UserDto> AddUserAsync(UserForCreationDto user);

        Task<UserDto> DeleteUserAsync(string userId);
    }
}
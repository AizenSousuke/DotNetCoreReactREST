using DotNetCoreReactREST.Entities;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Helper
{
    public interface IUserClassManager
    {
        Task<bool> RegisterAsync(ApplicationUser user);
        Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(ApplicationUser user, bool rememberMe);
        void SignOutAsync();
    }
}

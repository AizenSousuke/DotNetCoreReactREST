using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Helper
{
    public class UserClassManager : IUserClassManager
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserClassManager(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> RegisterAsync(ApplicationUser user)
        {
            try
            {
                var newUser = await _userManager.CreateAsync(user, user.PasswordHash);
                if (newUser.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(ApplicationUser user, bool rememberMe)
        {
            var result = await _signInManager.PasswordSignInAsync(user, user.PasswordHash, rememberMe, lockoutOnFailure: false);
            return result;
        }

        public async void SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}

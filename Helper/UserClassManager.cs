using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Helper
{
    public class UserClassManager : IUserClassManager
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserClassManager(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> RegisterAsync(IdentityUser user)
        {
            var newUser = await _userManager.CreateAsync(user, user.PasswordHash);
            if (newUser.Succeeded)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public async Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(IdentityUser user, bool rememberMe)
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

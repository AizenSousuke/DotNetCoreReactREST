using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Helper
{
    public interface IUserClassManager
    {
        Task<bool> RegisterAsync(IdentityUser user);
        Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(IdentityUser user, bool rememberMe);
        void SignOutAsync();
    }
}

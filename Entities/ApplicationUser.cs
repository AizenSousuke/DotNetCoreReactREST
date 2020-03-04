
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Models
{
    public class ApplicationUser : IdentityUser
    {
        //username
        //password
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
        public bool IsAdmin { get; set; }
    }
}

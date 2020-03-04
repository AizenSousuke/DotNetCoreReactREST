
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class ApplicationUser : IdentityUser
    { 
        //ID is string by default
        //username
        //password
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
        public bool IsAdmin { get; set; }
    }
}

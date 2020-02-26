using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Models
{
    public class User : IdentityUser
    {
        //Id
        //FirstName
        //LastName
        //email
        public IEnumerable<Post> Posts { get; set; } //Post Ids for front end
        public bool IsAdmin { get; set; }
    }
}
﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Entities
{
    public class ApplicationUser : IdentityUser
    {

        //ID is string by default
        //username
        //password
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public bool IsAdmin { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

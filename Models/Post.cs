using System;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } //backend only

        // Primary Keys to Votes.cs
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }

        // Primary Keys to Categories.cs
        public Categories Categories { get; set; } //backend only
        public int CategoryId { get; set; }

        // Primary Keys to Comment.cs
        public IEnumerable<Comment> Comments { get; set; }
    }
}
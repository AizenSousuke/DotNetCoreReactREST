using System;

namespace DotNetCoreReactREST.Models
{
    public class Comment
    {
        public Guid Id { get; set; } //backend generated
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } //only for backend
        public User User { get; set; } //only for backend
        public int UserId { get; set; }
    }
}
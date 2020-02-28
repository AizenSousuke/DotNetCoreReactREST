using System;

namespace DotNetCoreReactREST.Models
{
    public class Vote
    {
        public Guid Id { get; set; } //backend generated

        // Foreign Keys
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public ApplicationUser User { get; set; } //backend only
        public int UserId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } //backend only
    }
}
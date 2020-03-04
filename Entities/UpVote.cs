using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreReactREST.Entities
{
    public class UpVote
    {
        public int Id { get; set; } 
        public bool IsLiked { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } 
    }
}

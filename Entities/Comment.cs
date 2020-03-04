using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreReactREST.Entities
{
    public class Comment
    {
        public int Id { get; set; } 
        public long Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } 
        public ApplicationUser ApplicationUser { get; set; } 
        public int ApplicationUserId { get; set; }
    }
}

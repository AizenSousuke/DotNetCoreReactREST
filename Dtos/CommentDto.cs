
using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Dtos
{
    public class CommentDto
    {
        
        public int Id { get; set; }
        public string Content { get; set; }        
        public int PostId { get; set; }       
        public int ApplicationUserId { get; set; }
        public int LikesCount { get; set; }
    }
}

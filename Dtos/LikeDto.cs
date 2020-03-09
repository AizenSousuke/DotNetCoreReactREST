using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Dtos
{
    public class LikeDto
    {
        public int Id { get; set; }
        [Required]
        public bool IsLiked { get; set; }
        [Required]     
        public string ApplicationUserId { get; set; }
        [Required]
        public int CommentId { get; set; }
        
        
    }
}

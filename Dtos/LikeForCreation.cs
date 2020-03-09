using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Dtos
{
    public class LikeForCreation
    {        
        
        [Required]       
        public string ApplicationUserId { get; set; }
        [Required]
        public int CommentId { get; set; }
       
    }
}

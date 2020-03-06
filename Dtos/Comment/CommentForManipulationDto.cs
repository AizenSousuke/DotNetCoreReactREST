using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Dtos.Comment
{
    public abstract class CommentForManipulationDto
    {        
        [Required]
        [MaxLength(1000, ErrorMessage ="Content exceeds allowed length")]
        public string Content { get; set; }
        [Required]        
        public int PostId { get; set; }
        [Required]
        public int UserId { get; set; }
        
    }
}

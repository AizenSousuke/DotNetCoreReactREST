using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Dtos.Comment
{
    public class CommentDto
    {        
        public int Id { get; set; }        
        public string Content { get; set; }               
        public Post Post { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreReactREST.Entities
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public static bool IsLiked => true;       
        public ApplicationUser ApplicationUser { get; set; }        
        public string ApplicationUserId { get; set; }
        public Comment Comment { get; set; }        
        public int CommentId { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreReactREST.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }        
        public int PostId { get; set; }        
        public Post Post { get; set; }        
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsAnonymous { get; set; }       
        public ICollection<Like> Likes { get; set; } = new List<Like>();


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreReactREST.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }
        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public DateTime DateTime { get; set; }
        public IEnumerable<Like> Likes { get; set; } = new List<Like>();


    }
}

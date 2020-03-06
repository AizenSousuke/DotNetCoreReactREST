using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        //[MaxLength(50)] one of the post tiutle that were seeded exceeded 50 char
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
    }
}

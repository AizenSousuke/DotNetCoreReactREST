using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public Post Post { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}

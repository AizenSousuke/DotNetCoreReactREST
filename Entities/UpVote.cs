using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Models
{
    public class UpVote
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsLiked { get; set; }
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public int ApplicationUserId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public Post Post { get; set; }
    }
}

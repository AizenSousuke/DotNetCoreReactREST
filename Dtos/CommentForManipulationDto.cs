using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos
{
    public abstract class CommentForManipulationDto
    {
        [Required]
        [MaxLength(1000, ErrorMessage = "Content exceeds allowed length")]
        public string Content { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public bool IsAnonymous { get; set; }
    }
}

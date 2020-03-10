using System.ComponentModel.DataAnnotations;

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

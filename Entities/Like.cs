using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        public static bool IsLiked => true;

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}
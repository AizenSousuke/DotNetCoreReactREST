using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class PostLike
    {
        [Key]
        public int Id { get; set; }
        public bool IsLiked { get; set; } = true;
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class PostLike
    {
        [Key]
        public int Id { get; set; }
        public bool IsLiked { get; set; } = true;
        public string ApplicationUserId { get; set; }
        public int PostId { get; set; }
    }
}

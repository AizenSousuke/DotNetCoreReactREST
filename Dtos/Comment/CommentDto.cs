using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}

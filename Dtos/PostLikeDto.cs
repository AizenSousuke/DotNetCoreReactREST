namespace DotNetCoreReactREST.Dtos
{
    public class PostLikeDto
    {
        public int Id { get; set; }

        public bool IsLiked { get; set; }

        public string ApplicationUserId { get; set; }

        public int PostId { get; set; }
    }
}

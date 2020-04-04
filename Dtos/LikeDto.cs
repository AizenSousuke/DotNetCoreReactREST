namespace DotNetCoreReactREST.Dtos
{
    public class LikeDto
    {
        public int Id { get; set; }

        public bool IsLiked { get; set; }

        public string ApplicationUserId { get; set; }

        public int CommentId { get; set; }


    }
}

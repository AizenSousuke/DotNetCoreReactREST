using System;

namespace DotNetCoreReactREST.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public int LikesCount { get; set; }

        public string ApplicationUserId { get; set; }

        public bool IsAnonymous { get; set; }

        public string UserName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        public IEnumerable<Comment> GetAllComments();
        public Comment GetCommentById(int commentId);
        public void AddComment(Comment comment);
        public void UpdateComment(Comment comment);
        public void DeleteComment(Comment comment);
        public bool CommentExists(int commentId);
        public bool Save();
    }
}

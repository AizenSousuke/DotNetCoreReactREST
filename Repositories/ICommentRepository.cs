using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsForUser(string userId);
        IEnumerable<Comment> GetCommentsForPost(int postId);
        Comment GetCommentById(int commentId);
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
        bool CommentExists(int commentId);
        bool Save();
    }
}

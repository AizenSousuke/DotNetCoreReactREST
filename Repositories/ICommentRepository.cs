using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsForUser(string userId);
        Task<IEnumerable<Comment>> GetCommentsForPost(int postId);
        Task<Comment> GetCommentById(int commentId);
        Task AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
        Task<bool> CommentExists(int commentId);
        Task<bool> Save();
    }
}

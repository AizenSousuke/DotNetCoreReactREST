using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        Task AddComment(Comment comment);

        Task<bool> CommentExists(int commentId);

        void DeleteComment(Comment comment);

        Task<Comment> GetCommentById(int commentId);

        Task<IEnumerable<Comment>> GetCommentsForPost(int postId);

        Task<IEnumerable<Comment>> GetCommentsForUser(string userId);

        Task<bool> Save();

        void UpdateComment(Comment comment);
    }
}
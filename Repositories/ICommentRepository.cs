using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        Task<Comment> AddCommentAsync(Comment comment);

        Task<bool> CommentExistsAsync(int commentId);

        Task<Comment> DeleteCommentAsync(Comment comment);

        Task<Comment> GetCommentByIdAsync(int commentId);

        Task<IEnumerable<Comment>> GetCommentsForPostAsync(int postId);

        Task<IEnumerable<Comment>> GetCommentsForUserAsync(string userId);

        Task<bool> SaveAsync();

        void UpdateComment(Comment comment);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICommentRepository
    {
        Task AddCommentAsync(Comment comment);

        Task<bool> CommentExistsAsync(int commentId);

        Task<Comment> GetCommentByIdAsync(int commentId);

        Task<IEnumerable<Comment>> GetCommentsForPostAsync(int postId);

        Task<IEnumerable<Comment>> GetCommentsForUserAsync(string userId);

        Task<bool> SaveAsync();

        void UpdateCommentAsync(Comment comment);
    }
}
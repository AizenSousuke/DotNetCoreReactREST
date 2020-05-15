using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ILikeRepository
    {
        Task<Like> GetLikeByIdAsync(int likeId);

        Task<IEnumerable<Like>> GetLikesForCommentAsync(int commentId);

        Task<Like> LikeCommentAsync(Like like);

        Task<Like> LikeExistsAsync(int commentId, string userId);

        Task<bool> SaveAsync();

        Like UnlikeComment(Like like);
    }
}
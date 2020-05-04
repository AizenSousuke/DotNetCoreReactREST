using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ILikeRepository
    {
        Task<Like> GetLikeById(int likeId);

        Task<IEnumerable<Like>> GetLikesForComment(int commentId);

        Task<Like> LikeComment(Like like);

        Task<bool> LikeExists(int commentId, string userId);

        Task<bool> SaveAsync();

        void UnlikeComment(Like like);
    }
}
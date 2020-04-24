using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ILikeRepository
    {
        Like GetLikeById(int likeId);

        IEnumerable<Like> GetLikesForComment(int commentId);

        void LikeComment(Like like);

        bool LikeExists(int commentId, string userId);

        Task<bool> SaveAsync();

        void UnlikeComment(Like like);
    }
}
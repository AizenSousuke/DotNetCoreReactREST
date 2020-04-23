using System.Collections.Generic;
using DotNetCoreReactREST.Entities;

namespace DotNetCoreReactREST.Repositories
{
    public interface ILikeRepository
    {
        Like GetLikeById(int likeId);

        IEnumerable<Like> GetLikesForComment(int commentId);

        void LikeComment(Like like);

        bool LikeExists(int commentId, string userId);

        bool Save();

        void UnlikeComment(Like like);
    }
}
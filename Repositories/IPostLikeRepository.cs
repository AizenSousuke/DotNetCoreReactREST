using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostLikeRepository
    {
        IEnumerable<PostLike> GetLikesForPost(int postId);
        void LikePost(PostLike postLike);
        void UnlikePost(PostLike postLike);
        bool PostLikeExists(int postId, string userId);
        bool Save();
        PostLike GetPostLikeById(int postLikeId);
    }
}
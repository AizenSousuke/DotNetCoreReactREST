using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostLikeRepository
    {
        Task<List<PostLike>> GetLikesForPost(int postId);
        Task<List<PostLike>> LikePostAsync(PostLike postLike);
        void UnlikePost(PostLike postLike);
        Task<bool> PostLikeExists(int postId, string userId);
        Task<bool> SaveAsync();
        PostLike GetPostLikeById(int postLikeId);
    }
}
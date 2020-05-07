using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostLikeRepository
    {
        Task<List<PostLike>> GetLikesForPost(int postId);

        Task<PostLike> GetPostLikeById(int postLikeId);

        Task<PostLike> LikePostAsync(PostLike postLike);

        Task<PostLike> PostLikeExists(int postId, string userId);

        PostLike UnlikePost(PostLike postLike);

        Task<bool> SaveAsync();
    }
}
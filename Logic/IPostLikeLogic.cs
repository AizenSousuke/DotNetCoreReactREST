using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;

namespace DotNetCoreReactREST.Logic
{
    public interface IPostLikeLogic
    {
        Task<List<PostLikeDto>> GetLikesForPost(int postId);

        Task<PostLikeDto> LikePostAsync(int postId, string userId);
    }
}

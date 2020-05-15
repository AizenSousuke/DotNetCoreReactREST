using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;

namespace DotNetCoreReactREST.Logic
{
    public interface ILikeLogic
    {
        Task<IEnumerable<LikeDto>> GetLikesForCommentAsync(int commentId);

        Task<LikeDto> LikeCommentAsync(int commentId, string userId);

        Task<LikeDto> UnlikeCommentAsync(int likeId);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DotNetCoreReactREST.Logic
{
    public interface ICommentLogic
    {
        Task<CommentDto> CreateCommentAsync(CommentForCreationDto comment);

        Task<CommentDto> DeleteCommentAsync(int commentId);

        Task<CommentDto> EditCommentAsync(int commentId, JsonPatchDocument<Comment> patchDocument, ModelStateDictionary modelState);

        Task<CommentDto> GetCommentAsync(int commentId);

        Task<IEnumerable<CommentDto>> GetCommentsForPostAsync(int postId);

        Task<IEnumerable<CommentDto>> GetCommentsForUserAsync(string userId);
    }
}
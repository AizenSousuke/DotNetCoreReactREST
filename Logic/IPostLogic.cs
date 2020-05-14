using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DotNetCoreReactREST.Logic
{
    public interface IPostLogic
    {
        Task<PostDto> AddPostAsync(PostDto post);

        Task<PostDto> DeletePostAsync(int postId);

        Task<PostDto> GetPostByIdAsync(int postId);

        Task<PaginationResourceParameter<Post>> GetPostAsync(PaginationResourceParameter<Post> paginationResourceParameter);

        Task<PostDto> UpdatePostAsync(int postId, JsonPatchDocument<Post> patchDocument, ModelStateDictionary modelState);
    }
}

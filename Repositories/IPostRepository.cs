using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetPostsAsync();
        Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter);
        Task<Post> GetPostByIdAsync(int postId);
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post);
        Task<bool> DeletePostAsync(int postId);
        Task<bool> Save();
    }
}

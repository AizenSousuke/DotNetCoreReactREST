using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetPostsAsync();
        Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter);
        // Task<List<Post>> GetPostsAsync(PostResourceParameter postResourceParameter);
        Task<PaginationResourceParameter<Post>> GetPostsPaginationAsync(PaginationResourceParameter<Post> paginationResourceParameter, IQueryable<Post> collection = null);
        Task<Post> GetPostByIdAsync(int postId);
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post);
        Task<bool> DeletePostAsync(int postId);
        Task<bool> Save();
    }
}

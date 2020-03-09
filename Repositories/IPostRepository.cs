using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
        IEnumerable<Post> GetPosts(PostResourceParameter postResourceParameter);
        Task<Post> GetPostByIdAsync(int postId);   
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePost(int postId, JsonPatchDocument post);
        Task<bool> DeletePost(int postId);
        Task<bool> Save();
    }
}

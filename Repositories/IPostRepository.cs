using DotNetCoreReactREST.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
        Post GetPostById(int postId);
        Post[] GetPostByCategory(string category);
        Post GetPostByIdAndCategory(int postId, string category);
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePost(int postId, Post post);
        Task<bool> DeletePost(int postId);
        Task<bool> Save();
    }
}

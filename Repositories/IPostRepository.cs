using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        Task AddPostAsync(Post post);

        Task<Post> DeletePostAsync(int postId);

        Task<Post> GetPostByIdAsync(int postId);

        Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter);

        Task<bool> SaveAsync();
      
        Task<Post> UpdatePostAsync(int postId, JsonPatchDocument post);
    }
}
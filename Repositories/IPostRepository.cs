using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Repositories
{
    public interface IPostRepository
    {
        Task AddPostAsync(Post post);

        void DeletePost(Post post);

        Task<Post> GetPostByIdAsync(int postId);

        Task<PaginationResourceParameter<Post>> GetPostsAsync(PaginationResourceParameter<Post> paginationResourceParameter);

        Task<bool> SaveAsync();
    }
}
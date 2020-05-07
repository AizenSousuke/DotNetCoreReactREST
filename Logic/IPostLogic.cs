using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Logic
{
    public interface IPostLogic
    {
        Task<PostDto> AddPostAsync(PostDto post);

        Task<PostDto> DeletePostAsync(int postId);

        Task<PostDto> GetPostByIdAsync(int postId);

        Task<PaginationResourceParameter<PostDto>> GetPostAsync(PaginationResourceParameter<Post> paginationResourceParameter);

        Task<PostDto> UpdatePostAsync(int postId, PostDto postDto);
    }
}

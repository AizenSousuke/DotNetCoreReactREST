using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Logic
{
    public class PostLogic : IPostLogic
    {
        public Task<PostDto> AddPostAsync(PostDto post)
        {
            throw new NotImplementedException();
        }

        public Task<PostDto> DeletePostAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<PostDto> UpdatePostAsync(int postId, PostDto postDto)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResourceParameter<PostDto>> GetPostAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            throw new NotImplementedException();
        }

        public Task<PostDto> GetPostByIdAsync(int postId)
        {
            throw new NotImplementedException();
        }
    }
}

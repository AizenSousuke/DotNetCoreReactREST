using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;
using DotNetCoreReactREST.Services;

namespace DotNetCoreReactREST.Logic
{
    public class PostLogic : IPostLogic
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;

        public PostLogic(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<PostDto> AddPostAsync(PostDto post)
        {
            // Replace with Imgur URL of the image
            post.ImageUrl = await new ImageUpload().Upload(post.ImageUrl);

            Post newPost = await _postRepository.AddPostAsync(_mapper.Map<Post>(post));
            return _mapper.Map<PostDto>(newPost);
        }

        public async Task<PostDto> DeletePostAsync(int postId)
        {
            var post = await _postRepository.GetPostByIdAsync(postId);
            if (post == null)
            {
                return null;
            }

            Post deletedPost = await _postRepository.DeletePostAsync(postId);
            if (deletedPost == null)
            {
                return null;
            }

            return _mapper.Map<PostDto>(deletedPost);
        }

        public async Task<PostDto> GetPostByIdAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginationResourceParameter<PostDto>> GetPostAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            throw new NotImplementedException();
        }

        public async Task<PostDto> UpdatePostAsync(int postId, PostDto postDto)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;
using DotNetCoreReactREST.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Serilog;

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
            Post postFromRepository = await _postRepository.GetPostByIdAsync(postId);
            Log.Information("Post from Repository when getting post by id: {@0}", postFromRepository);
            if (postFromRepository == null)
            {
                return null;
            }

            if (postFromRepository.IsDeleted)
            {
                return null;
            }

            return _mapper.Map<PostDto>(postFromRepository);
        }

        public async Task<PaginationResourceParameter<Post>> GetPostAsync(PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = await _postRepository.GetPostsAsync(paginationResourceParameter);
            if (result == null)
            {
                return null;
            }

            return result;
        }

        public async Task<PostDto> UpdatePostAsync(int postId, JsonPatchDocument<Post> patchDocument, ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                return null;
            }

            // Post to update
            Post oldPost = await _postRepository.GetPostByIdAsync(postId);
            string prePatchImageUrl = oldPost.ImageUrl;
            if (oldPost == null)
            {
                return null;
            }
            else
            {
                if (oldPost.IsDeleted)
                {
                    return null;
                }

                patchDocument.ApplyTo(oldPost, modelState);
                string postPatchImageUrl = oldPost.ImageUrl;
                if (!modelState.IsValid)
                {
                    return null;
                }

                // Update time
                oldPost.DateTime = DateTime.Now;
                // Replace with Imgur URL of the updated image
                if (prePatchImageUrl != postPatchImageUrl)
                {
                    oldPost.ImageUrl = await new ImageUpload().Upload(oldPost.ImageUrl);
                }

                // Save
                bool isSaved = await _postRepository.SaveAsync();
                if (!isSaved)
                {
                    return null;
                }

                // Updated post
                Post newPost = await _postRepository.GetPostByIdAsync(oldPost.Id);
                if (newPost == null)
                {
                    return null;
                }

                return _mapper.Map<PostDto>(newPost);
            }
        }
    }
}

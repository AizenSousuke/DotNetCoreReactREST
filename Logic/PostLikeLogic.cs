using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Serilog;

namespace DotNetCoreReactREST.Logic
{
    public class PostLikeLogic : IPostLikeLogic
    {
        private readonly IMapper _mapper;
        private readonly IPostLikeRepository _postLikeRepository;
        private readonly IPostRepository _postRepository;

        public PostLikeLogic(
            IMapper mapper,
            IPostLikeRepository postLikeRepo,
            IPostRepository postRepository)
        {
            _mapper = mapper;
            _postLikeRepository = postLikeRepo;
            _postRepository = postRepository;
        }

        public async Task<List<PostLikeDto>> GetLikesForPost(int postId)
        {
            Post postExists = await _postRepository.GetPostByIdAsync(postId);
            if (postExists == null)
            {
                return null;
            }

            List<PostLike> postLikesFromRepo = await _postLikeRepository.GetLikesForPost(postId);
            if (postLikesFromRepo == null)
            {
                return null;
            }

            return _mapper.Map<List<PostLikeDto>>(postLikesFromRepo);
        }

        public async Task<PostLikeDto> LikePostAsync(int postId, string userId)
        {
            Log.Information("PostId: {@PostId}, UserId: {@UserId}", postId, userId);

            // Check if post exists
            Post postExists = await _postRepository.GetPostByIdAsync(postId);
            if (postExists == null)
            {
                return null;
            }

            // PostLike is unique to user, so none should exist
            PostLike postLike = await _postLikeRepository.PostLikeExists(postId, userId);
            if (postLike == null)
            {
                // If PostLike doesn't exists, create new one
                PostLike newlyCreatedPostLike = await _postLikeRepository.LikePostAsync(
                    new PostLike
                    {
                        PostId = postId,
                        ApplicationUserId = userId,
                        IsLiked = true,
                    });
                if (newlyCreatedPostLike == null)
                {
                    return null;
                }

                return _mapper.Map<PostLikeDto>(newlyCreatedPostLike);
            }

            postLike.IsLiked = !postLike.IsLiked;
            bool isSaved = await _postLikeRepository.SaveAsync();
            if (!isSaved)
            {
                return null;
            }

            PostLike newPostLike = await _postLikeRepository.GetPostLikeById(postLike.Id);
            if (newPostLike == null)
            {
                return null;
            }

            return _mapper.Map<PostLikeDto>(newPostLike);
        }
    }
}

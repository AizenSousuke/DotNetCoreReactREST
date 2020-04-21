using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/")]
    public class PostLikesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPostLikeRepository _postLikeRepository;
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepo;
        public PostLikesController(IPostLikeRepository postLikeRepo,
            IPostRepository postRepository, IUserRepository userRepo, IMapper mapper)
        {
            _postLikeRepository = postLikeRepo;
            _postRepository = postRepository;
            _userRepo = userRepo;
            _mapper = mapper;

        }

        [HttpGet]
        [Route("posts/{postId}/postlikes")]
        public async Task<IActionResult> GetPostLikesForPost(int postId)
        {
            var postExists = await _postRepository.GetPostByIdAsync(postId);
            if (postExists == null)
            {
                return NotFound("Post doesn't exist.");
            }
            var postLikesFromRepo = await _postLikeRepository.GetLikesForPost(postId);
            return Ok(_mapper.Map<List<PostLikeDto>>(postLikesFromRepo));
        }

        //Authenticate to make sure userId is the same as logged user
        [HttpPost]
        [Route("posts/{postId:int}/users/{userId}/postlikes")]
        public async Task<IActionResult> LikePostAsync([FromRoute]int postId, [FromRoute]string userId)
        {
            Log.Information("PostId: {@PostId}, UserId: {@UserId}", postId, userId);
            // Check if post exists
            var postExists = await _postRepository.GetPostByIdAsync(postId);
            if (postExists == null)
            {
                return NotFound("Post doesn't exists.");
            };
            // PostLike is unique to user, so none should exist
            bool postLikeExists = await _postLikeRepository.PostLikeExists(postId, userId);
            if (postLikeExists)
            {
                return Ok("Post has already been liked.");
            }
            var results = await _postLikeRepository.LikePostAsync(
                new PostLike
                {
                    PostId = postId,
                    ApplicationUserId = userId,
                    IsLiked = true
                });
            if (results != null)
            {
                await _postLikeRepository.SaveAsync();
                return Ok(results);
            }

            return Problem("Problem with Database.");
        }

        //Authenticate to make sure userId is the same as logged user
        [HttpDelete]
        [Route("postlikes/{postLikeId:int}")]
        public async Task<IActionResult> UnlikePostAsync(int postLikeId)
        {
            var postFromRepo = _postLikeRepository.GetPostLikeById(postLikeId);
            if (postFromRepo == null)
            {
                return NotFound("No likes on post.");
            }
            _postLikeRepository.UnlikePost(postFromRepo);
            var saved = await _postLikeRepository.SaveAsync();
            if (saved)
            {
                var result = await _postLikeRepository.GetLikesForPost(postFromRepo.PostId);
                return Ok(result);
            }
            return Problem("Not saved.");
        }
    }
}



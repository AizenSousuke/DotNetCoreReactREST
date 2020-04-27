using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serilog;

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

        public PostLikesController(
            IMapper mapper,
            IPostLikeRepository postLikeRepo,
            IPostRepository postRepository,
            IUserRepository userRepo)
        {
            _mapper = mapper;
            _postLikeRepository = postLikeRepo;
            _postRepository = postRepository;
            _userRepo = userRepo;
        }

        // GET: Api/Posts/{PostId}/PostLikes
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

        // POST: Api/Posts/{PostId}/Users/{UserId}/PostLikes
        // Authenticate to make sure userId is the same as logged user
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
            }

            // PostLike is unique to user, so none should exist
            PostLike postLike = await _postLikeRepository.PostLikeExists(postId, userId);
            if (postLike != null)
            {
                postLike.IsLiked = !postLike.IsLiked;
                bool result = await _postLikeRepository.SaveAsync();
                if (result)
                {
                    return Ok(_mapper.Map<PostLikeDto>(await _postLikeRepository.GetPostLikeById(postLike.Id)));
                }

                return Problem("Problem with Database.");
            }

            // If PostLike doesn't exists, create new one
            PostLike results = await _postLikeRepository.LikePostAsync(
                new PostLike
                {
                    PostId = postId,
                    ApplicationUserId = userId,
                    IsLiked = true,
                });
            if (results != null)
            {
                return Ok(_mapper.Map<PostLikeDto>(results));
            }

            return Problem("Problem with Database.");
        }

        // DELETE: Api/PostLikes/{PostLikeId}
        // Authenticate to make sure userId is the same as logged user
        [HttpDelete]
        [Route("postlikes/{postLikeId:int}")]
        public async Task<IActionResult> UnlikePostAsync(int postLikeId)
        {
            var postFromRepo = await _postLikeRepository.GetPostLikeById(postLikeId);
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
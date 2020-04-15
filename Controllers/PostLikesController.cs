using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class PostLikesController : ControllerBase
    {
        private readonly IPostLikeRepository _postLikeRepository;
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public PostLikesController(IPostLikeRepository postLikeRepo,
            IPostRepository postRepository, IUserRepository userRepo, IMapper mapper)
        {
            _postLikeRepository = postLikeRepo;
            _postRepository = postRepository;
            _userRepo = userRepo;
            _mapper = mapper;

        }

        [HttpGet("posts/{postId}/postlikes")]
        public async Task<ActionResult<IEnumerable<PostLikeDto>>> GetPostLikesForPost(int postId)
        {
            var postExists = await _postRepository.GetPostByIdAsync(postId);
            if (postExists == null)
            {
                return BadRequest("Post doesn't exist.");
            }
            var postLikesFromRepo = _postLikeRepository.GetLikesForPost(postId);
            return Ok(_mapper.Map<IEnumerable<PostLikeDto>>(postLikesFromRepo));
        }

        //Authenticate to make sure userId is the same as logged user

        [HttpPost("posts/{postId}/users/{userId}/postlikes")]
        public ActionResult LikePost(int postId, string userId)
        {
            //like is unique to user, so none should exist
            if (_postLikeRepository.PostLikeExists(postId, userId))
            {
                return BadRequest("Post has already been liked.");
            }
            _postLikeRepository.LikePost(
                new PostLike { 
                    PostId = postId, 
                    ApplicationUserId = userId,
                    IsLiked = true
                });
            _postLikeRepository.Save();
            return Ok("Post has been liked.");
        }

        //Authenticate to make sure userId is the same as logged user

        [HttpDelete("postlikes/{postLikeId}")]
        public ActionResult UnlikePost(int postLikeId)
        {
            var postFromRepo = _postLikeRepository.GetPostLikeById(postLikeId);
            if (postFromRepo == null)
            {
                return BadRequest("No likes on post.");
            }
            _postLikeRepository.UnlikePost(postFromRepo);
            _postLikeRepository.Save();
            return Ok("Likes has been removed.");
        }
    }
}



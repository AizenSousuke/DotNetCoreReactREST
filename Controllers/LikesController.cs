using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        private readonly ILikeRepository _likeRepo;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;

        public LikesController(
            ICommentRepository commentRepo,
            ILikeRepository likeRepo,
            IMapper mapper,
            IUserRepository userRepo)
        {
            _commentRepo = commentRepo;
            _likeRepo = likeRepo;
            _mapper = mapper;
            _userRepo = userRepo;
        }

        // GET: Api/Comments/{CommentId}/Likes
        [HttpGet("comments/{commentId}/likes")]
        public async Task<IActionResult> GetLikesForComment(int commentId)
        {
            var commentExists = await _commentRepo.CommentExists(commentId);
            if (!commentExists)
            {
                return BadRequest("Comment doesn't exist.");
            }

            var likesFromRepo = await _likeRepo.GetLikesForComment(commentId);
            return Ok(_mapper.Map<List<LikeDto>>(likesFromRepo));
        }

        // POST: Api/Comments/{CommentId}/User/{UserId}/Likes
        // Authenticate to make sure userId is the same as logged user
        [HttpPost("comments/{commentId}/users/{userId}/Likes")]
        public async Task<IActionResult> LikeComment(int commentId, string userId)
        {
            // Like is unique to user, so none should exist
            bool exists = await _likeRepo.LikeExists(commentId, userId);
            if (exists)
            {
                return BadRequest("Comment has been liked.");
            }

            Like results = await _likeRepo.LikeComment(new Like { CommentId = commentId, ApplicationUserId = userId });
            if (results != null)
            {
                return Ok(results);
            }

            return Problem("Problem with Database.");
        }

        // DELETE: Api/Likes/{LikeId}
        // Authenticate to make sure userId is the same as logged user
        [HttpDelete("likes/{likeId}")]
        public async Task<IActionResult> UnLike(int likeId)
        {
            var commentFromRepo = await _likeRepo.GetLikeById(likeId);
            if (commentFromRepo == null)
            {
                return BadRequest("No likes on comment.");
            }

            _likeRepo.UnlikeComment(commentFromRepo);
            bool result = await _likeRepo.SaveAsync();
            if (result)
            {
                return Ok("Likes has been removed.");
            }

            return Problem("Not saved.");
        }
    }
}
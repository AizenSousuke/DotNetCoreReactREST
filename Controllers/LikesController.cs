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
    public class LikesController : ControllerBase
    {
        private readonly ILikeRepository _likeRepo;
        private readonly ICommentRepository _commentRepo;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public LikesController(ILikeRepository likeRepo,
            ICommentRepository commentRepo, IUserRepository userRepo, IMapper mapper)
        {
            _likeRepo = likeRepo;
            _commentRepo = commentRepo;
            _userRepo = userRepo;
            _mapper = mapper;

        }
        // GET: Api/Comments/{CommentId}/likes
        [HttpGet("comments/{commentId}/likes")]
        public async Task<ActionResult<IEnumerable<LikeDto>>> GetLikesForComment(int commentId)
        {
            var commentExists = await _commentRepo.CommentExists(commentId);
            if (!commentExists)
            {
                return BadRequest("Comment doesn't exist.");
            }
            var likesFromRepo = _likeRepo.GetLikesForComment(commentId);
            return Ok(_mapper.Map<IEnumerable<LikeDto>>(likesFromRepo));
        }

        //Authenticate to make sure userId is the same as logged user
        //POST api/Comments/{commentId}/user/{userId}/Likes
        [HttpPost("comments/{commentId}/users/{userId}/Likes")]
        public ActionResult LikeComment(int commentId, string userId)
        {
            //like is unique to user, so none should exist
            if (_likeRepo.LikeExists(commentId, userId))
            {
                return BadRequest("Comment has been liked.");
            }
            _likeRepo.LikeComment(new Like { CommentId = commentId, ApplicationUserId = userId });
            _likeRepo.Save();
            return Ok("Comment has been liked.");
        }

        //Authenticate to make sure userId is the same as logged user
        //DELETE api/likes/{likeId}
        [HttpDelete("likes/{LikeId}")]
        public ActionResult UnLike(int likeId)
        {
            var commentFromRepo = _likeRepo.GetLikeById(likeId);
            if (commentFromRepo == null)
            {
                return BadRequest("No likes on comment.");
            }
            _likeRepo.UnlikeComment(commentFromRepo);
            _likeRepo.Save();
            return Ok("Likes has been removed.");
        }
    }
}



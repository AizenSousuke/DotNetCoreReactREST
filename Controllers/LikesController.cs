using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class LikesController : Controller
    {
        private ILikeRepository _likeRepo;
        private ICommentRepository _commentRepo;
        private IUserRepository _userRepo;
        private IMapper _mapper;
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
        public ActionResult<IEnumerable<LikeDto>> GetLikesForComment(int commentId)
        {
            if (!_commentRepo.CommentExists(commentId))
            {
                return BadRequest();
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
                return BadRequest();
            }
            _likeRepo.LikeComment(new Like { CommentId = commentId, ApplicationUserId = userId });
            _likeRepo.Save();
            return NoContent();
        }

        //Authenticate to make sure userId is the same as logged user
        //DELETE api/likes/{likeId}
        [HttpDelete("likes/{LikeId}")]
        public ActionResult UnLike(int likeId)
        {
            var commentFromRepo = _likeRepo.GetLikeById(likeId);
            if (commentFromRepo == null)
            {
                return BadRequest();
            }
            _likeRepo.UnlikeComment(commentFromRepo);
            _likeRepo.Save();
            return NoContent();
        }
    }
}



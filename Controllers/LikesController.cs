using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly ILikeLogic _likeLogic;
        private readonly IMapper _mapper;

        public LikesController(ILikeLogic likeLogic, IMapper mapper)
        {
            _likeLogic = likeLogic;
            _mapper = mapper;
        }

        // GET: api/comments/{commentId}/likes
        [HttpGet("comments/{commentId}/likes")]
        public async Task<ActionResult> GetLikesForComment(int commentId)
        {
            IEnumerable<LikeDto> result = await _likeLogic.GetLikesForCommentAsync(commentId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/comments/{commentId}/user/{userId}/likes
        // Authenticate to make sure userId is the same as logged user
        [HttpPost("comments/{commentId}/users/{userId}/Likes")]
        public async Task<ActionResult> LikeComment(int commentId, string userId)
        {
            LikeDto result = await _likeLogic.LikeCommentAsync(commentId, userId);

            if (result == null)
            {
                return Problem();
            }

            return Ok(result);
        }

        // DELETE: api/likes/{likeId}
        // Authenticate to make sure userId is the same as logged user
        [HttpDelete("likes/{likeId}")]
        public async Task<ActionResult> Unlike(int likeId)
        {
            LikeDto result = await _likeLogic.UnlikeCommentAsync(likeId);

            if (result == null)
            {
                return Problem();
            }

            return Ok(result);
        }
    }
}
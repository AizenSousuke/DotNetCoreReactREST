using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Logic;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/")]
    public class PostLikesController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IPostLikeLogic _postLikeLogic;

        public PostLikesController(
            IUserRepository userRepo,
            IPostLikeLogic postLikeLogic)
        {
            _userRepo = userRepo;
            _postLikeLogic = postLikeLogic;
        }

        // GET: Api/Posts/{PostId}/PostLikes
        [HttpGet]
        [Route("posts/{postId:int}/postlikes")]
        public async Task<IActionResult> GetPostLikesForPost([FromRoute]int postId)
        {
            List<PostLikeDto> postLikesFromRepo = await _postLikeLogic.GetLikesForPost(postId);
            if (postLikesFromRepo == null)
            {
                return NotFound();
            }

            return Ok(postLikesFromRepo);
        }

        // POST: Api/Posts/{PostId}/Users/{UserId}/PostLikes
        // Authenticate to make sure userId is the same as logged user
        [HttpPost]
        [Route("posts/{postId:int}/users/{userId}/postlikes")]
        public async Task<IActionResult> LikePostAsync([FromRoute]int postId, [FromRoute]string userId)
        {
            PostLikeDto postLike = await _postLikeLogic.LikePostAsync(postId, userId);
            if (postLike == null)
            {
                return Problem();
            }

            return Ok(postLike);
        }
    }
}
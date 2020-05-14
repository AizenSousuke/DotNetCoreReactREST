using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentLogic _commentLogic;

        public CommentsController(ICommentLogic commentLogic)
        {
            _commentLogic = commentLogic;
        }

        // POST: api/comments
        [HttpPost("comments")]
        public async Task<ActionResult<CommentDto>> CreateComment(CommentForCreationDto comment)
        {
            CommentDto addedComment = await _commentLogic.CreateCommentAsync(comment);

            if (addedComment == null)
            {
                return Problem();
            }

            return Ok(addedComment);
        }

        // DELETE: api/comments/{commentId}
        [HttpDelete("comments/{commentId}")]
        public async Task<ActionResult> DeleteComment(int commentId)
        {
            CommentDto deletedComment = await _commentLogic.DeleteCommentAsync(commentId);

            if (deletedComment == null)
            {
                return Problem();
            }

            return Ok(deletedComment);
        }

        // PATCH: api/comments/{commentId}
        [HttpPatch("comments/{commentId}")]
        public async Task<ActionResult> EditComment(
            [FromRoute]int commentId,
            [FromBody]JsonPatchDocument<Comment> patchDocument)
        {
            // TODO: Temporary stays here. Don't know how to move it into business logic layer
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            CommentDto result = await _commentLogic.EditCommentAsync(commentId, patchDocument, ModelState);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/comments/{commentId}
        [HttpGet("comments/{commentId}", Name = "GetComment")]
        public async Task<ActionResult<CommentDto>> GetComment(int commentId)
        {
            CommentDto result = await _commentLogic.GetCommentAsync(commentId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/posts/{postId}/comments
        [HttpGet("posts/{postId:int}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForPost(int postId)
        {
            IEnumerable<CommentDto> result = await _commentLogic.GetCommentsForPostAsync(postId);

            return Ok(result);
        }

        // GET: api/users/{userId}/comments
        [HttpGet("users/{userId}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForUser(string userId)
        {
            IEnumerable<CommentDto> result = await _commentLogic.GetCommentsForUserAsync(userId);

            return Ok(result);
        }

        // This overrides validation behavior in patch to show more detailed error info if model is
        // invalid
        public override ActionResult ValidationProblem(
           [ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();
            return (ActionResult)options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }
    }
}
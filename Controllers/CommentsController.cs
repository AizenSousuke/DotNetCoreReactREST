using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
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
        private readonly ICommentRepository _commentRepo;
        private readonly IMapper _mapper;

        public CommentsController(ICommentRepository commentRepo, IMapper mapper)
        {
            _commentRepo = commentRepo;
            _mapper = mapper;
        }

        // POST: Api/Comments
        [HttpPost("comments")]
        public async Task<ActionResult<CommentDto>> CreateCommentAsync(CommentForCreationDto comment)
        {
            Comment commentToAdd = _mapper.Map<Comment>(comment);
            Comment commentToReturn = await _commentRepo.AddCommentAsync(commentToAdd);
            return Ok(_mapper.Map<CommentDto>(commentToReturn));
        }

        // DELETE: Api/Comments/{CommentId}
        [HttpDelete("comments/{commentId}")]
        public async Task<ActionResult> DeleteAsync(int commentId)
        {
            Comment commentFromRepo = await _commentRepo.GetCommentByIdAsync(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }

            Comment deletedComment = await _commentRepo.DeleteCommentAsync(commentFromRepo);
            return Ok(_mapper.Map<CommentDto>(deletedComment));
        }

        // GET: Api/Comments/{CommentId}
        [HttpGet("comments/{commentId}", Name = "GetComment")]
        public async Task<ActionResult> GetCommentForUserAsync(int commentId)
        {
            Comment commentFromRepo = await _commentRepo.GetCommentByIdAsync(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }
            if (commentFromRepo.IsDeleted)
            {
                return BadRequest("Comment has been deleted.");
            }

            return Ok(_mapper.Map<CommentDto>(commentFromRepo));
        }

        // GET: Api/Posts/{PostId}/Comments
        [HttpGet("posts/{postId:int}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForPostAsync(int postId)
        {
            IEnumerable<Comment> commentsFromRepo = await _commentRepo.GetCommentsForPostAsync(postId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        // GET: Api/Users/{UserId}/Comments
        [HttpGet("users/{userId}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForUserAsync(string userId)
        {
            IEnumerable<Comment> commentsFromRepo = await _commentRepo.GetCommentsForUserAsync(userId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        // PATCH: Api/Comments/{CommentId}
        [HttpPatch("comments/{commentId}")]
        public async Task<IActionResult> UpdateCommentAsync(
            [FromRoute]int commentId,
            [FromBody]JsonPatchDocument<Comment> patchDocument)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            Comment commentFromRepo = await _commentRepo.GetCommentByIdAsync(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }

            if (commentFromRepo.IsDeleted)
            {
                return BadRequest("Cannot update a deleted comment.");
            }

            // Patch passing in modelstate to patch item to be aware of
            patchDocument.ApplyTo(commentFromRepo, ModelState);
            commentFromRepo.DateTime = DateTime.Now;
            _commentRepo.UpdateComment(commentFromRepo);
            await _commentRepo.SaveAsync();
            Comment updatedComment = await _commentRepo.GetCommentByIdAsync(commentId);
            if (updatedComment != null)
            {
                return Ok(_mapper.Map<CommentDto>(updatedComment));
            }

            return NotFound();
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
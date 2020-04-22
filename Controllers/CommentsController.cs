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
using System.Collections.Generic;
using System.Threading.Tasks;

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

        // POST api/comments
        [HttpPost("comments")]
        public async Task<ActionResult<CommentDto>> CreateComment(CommentForCreationDto comment)
        {
            var commentToAdd = _mapper.Map<Comment>(comment);
            await _commentRepo.AddComment(commentToAdd);
            await _commentRepo.Save();

            var commentToReturn = _mapper.Map<CommentDto>(commentToAdd);
            return CreatedAtRoute("GetComment",
                new { commentId = commentToReturn.Id },
                commentToReturn);
        }

        // DELETE api/comments/{commentId}
        [HttpDelete("comments/{commentId}")]
        public async Task<ActionResult> Delete(int commentId)
        {
            var commentFromRepo = await _commentRepo.GetCommentById(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }
            _commentRepo.DeleteComment(commentFromRepo);
            await _commentRepo.Save();
            return NoContent();
        }

        // GET api/comments/{commentId}
        [HttpGet("comments/{commentId}", Name = "GetComment")]
        public async Task<ActionResult> GetCommentForUser(int commentId)
        {
            var commentFromRepo = await _commentRepo.GetCommentById(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommentDto>(commentFromRepo));
        }

        [HttpGet("posts/{postId:int}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForPost(int postId)
        {
            var commentsFromRepo = await _commentRepo.GetCommentsForPost(postId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        // GET: api/users/{userId}/comments
        [HttpGet("users/{userId}/comments")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetCommentsForUser(string userId)
        {
            var commentsFromRepo = await _commentRepo.GetCommentsForUser(userId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        // PUT comments/{commentId}
        [HttpPut("comments/{commentId}")]
        public async Task<ActionResult> UpdateComment(int commentId, CommentForUpdateDto comment)
        {
            var commentToUpdate = await _commentRepo.GetCommentById(commentId);
            if (commentToUpdate == null)
            {
                return BadRequest();
            }
            _mapper.Map(comment, commentToUpdate);

            _commentRepo.UpdateComment(commentToUpdate);
            await _commentRepo.Save();

            return NoContent();
        }

        //api/comments/commentId
        [HttpPatch("comments/{commentId}")]
        public async Task<ActionResult> UpdateCommentPartially(int commentId,
            JsonPatchDocument<CommentForUpdateDto> patchDocument)
        {
            var commentFromRepo = await _commentRepo.GetCommentById(commentId);
            if (commentFromRepo == null)
            {
                return BadRequest();
            }

            //map comment from repo to a commentForUpdateDto
            var commentToPatch = _mapper.Map<CommentForUpdateDto>(commentFromRepo);
            //patch passing in modelstate to patch item to be aware of
            patchDocument.ApplyTo(commentToPatch, ModelState);

            if (!TryValidateModel(commentToPatch))
            {
                return ValidationProblem(ModelState);
            }

            //does nothing, just following convention
            _mapper.Map(commentToPatch, commentFromRepo);
            _commentRepo.UpdateComment(commentFromRepo);
            await _commentRepo.Save();

            return NoContent();
        }

        //this overrides validation behavior in patch to show
        //more detailed error info if model is invalid
        public override ActionResult ValidationProblem(
           [ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();
            return (ActionResult)options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }
    }
}
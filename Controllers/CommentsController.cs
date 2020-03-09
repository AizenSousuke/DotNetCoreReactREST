using AutoMapper;
using DotNetCoreReactREST.Dtos.Comment;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Controllers
{
    [Route("api")]
    [ApiController]
    public class CommentsController : Controller
    {
        private ICommentRepository _commentRepo;
        private IMapper _mapper;

        public CommentsController(ICommentRepository commentRepo, IMapper mapper)
        {
            _commentRepo = commentRepo;
            _mapper = mapper;
        }
        // GET: api/users/{userId}/comments
        [HttpGet("users/{userId}/comments")]
        public ActionResult<IEnumerable<Comment>> GetCommentsForUser(string userId)
        {
            var commentsFromRepo = _commentRepo.GetCommentsForUser(userId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        [HttpGet("posts/{postId}/comments")]
        public ActionResult<IEnumerable<Comment>> GetCommentsForPost(int postId)
        {
            var commentsFromRepo = _commentRepo.GetCommentsForPost(postId);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }

        // GET api/comments/{commentId}
        [HttpGet("Comments/{commentId}", Name = "GetComment")]
        public ActionResult GetCommentForUser(int commentId)
        {
            var commentFromRepo = _commentRepo.GetCommentById(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CommentDto>(commentFromRepo));
        }

        // POST api/comments
        [HttpPost("comments")]
        public ActionResult<CommentDto> CreateComment(CommentForCreationDto comment)
        {
            var commentToAdd = _mapper.Map<Comment>(comment);
            _commentRepo.AddComment(commentToAdd);
            _commentRepo.Save();

            var commentToReturn = _mapper.Map<CommentDto>(commentToAdd);
            return CreatedAtRoute("GetComment",
                new { commentId = commentToReturn.Id },
                commentToReturn);
        }

        // PUT comments/{commentId}
        [HttpPut("comments/{commentId}")]
        public ActionResult UpdateComment(int commentId, CommentForUpdateDto comment)
        {
            var commentToUpdate = _commentRepo.GetCommentById(commentId);
            if (commentToUpdate == null)
            {
                return BadRequest();
            }
            _mapper.Map(comment, commentToUpdate);

            _commentRepo.UpdateComment(commentToUpdate);
            _commentRepo.Save();

            return NoContent();
        }

        //api/comments/commentId
        [HttpPatch("comments/{commentId}")]
        public ActionResult UpdateCommentPartially(int commentId,
            JsonPatchDocument<CommentForUpdateDto> patchDocument)
        {
            var commentFromRepo = _commentRepo.GetCommentById(commentId);
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
            _commentRepo.Save();

            return NoContent();
        }


        // DELETE api/comments/{commentId}
        [HttpDelete("comments/{commentId}")]
        public ActionResult Delete(int commentId)
        {
            var commentFromRepo = _commentRepo.GetCommentById(commentId);
            if (commentFromRepo == null)
            {
                return NotFound();
            }
            _commentRepo.DeleteComment(commentFromRepo);
            _commentRepo.Save();
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

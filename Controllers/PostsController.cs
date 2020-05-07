using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostLogic _postLogic;

        public PostsController(
            IPostLogic postLogic)
        {
            _postLogic = postLogic;
        }

        // POST: Api/Posts
        [HttpPost]
        public async Task<IActionResult> AddPostAsync([FromBody]PostDto post)
        {
            PostDto newPost = await _postLogic.AddPostAsync(post);

            var baseURI = Request.GetDisplayUrl();
            return Created(baseURI + newPost.Id, newPost);
        }

        // DELETE: Api/Posts/{PostId}
        [HttpDelete("{postId:int}")]
        public async Task<IActionResult> DeletePostAsync([FromRoute]int postId)
        {
            PostDto deletedPost = await _postLogic.DeletePostAsync(postId);
            if (deletedPost == null)
            {
                return NotFound();
            }

            return Ok(deletedPost);
        }

        // GET: Api/Posts/{PostId}
        // Route will only match if postId can be casted as a int
        [HttpGet]
        [Route("{postId:int}")]
        public async Task<IActionResult> GetPostByIdAsync([FromRoute]int postId)
        {
            PostDto post = await _postLogic.GetPostByIdAsync(postId);
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // GET: Api/Posts[category = string &| searchQuery = string]
        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetPostsAsync([FromQuery]PaginationResourceParameter<Post> paginationResourceParameter)
        {
            PaginationResourceParameter<Post> result = await _postLogic.GetPostAsync(paginationResourceParameter);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PATCH: Api/Posts/{PostId}
        [HttpPatch("{postId:int}", Name = "{postId:int}")]
        public async Task<IActionResult> UpdatePostAsync([FromRoute]int postId, [FromBody]JsonPatchDocument<Post> patchDocument)
        {
            PostDto updatedPost = await _postLogic.UpdatePostAsync(postId, patchDocument, ModelState);
            if (updatedPost == null)
            {
                return Problem();
            }

            return Ok(updatedPost);
        }
    }
}
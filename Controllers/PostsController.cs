using System;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;
using DotNetCoreReactREST.Services;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        // POST: Api/Posts
        [HttpPost]
        public async Task<IActionResult> CreatePostAsync([FromBody]PostDto post)
        {
            // Replace with Imgur URL of the image
            post.ImageUrl = await new ImgurService().Upload(post.ImageUrl);

            Post newPost = await _postRepository.CreatePostAsync(_mapper.Map<Post>(post));

            // Alternative way
            // var baseURI = Request.Scheme + "://" + Request.Host + Request.Path;
            var baseURI = Request.GetDisplayUrl();

            return Created(baseURI + newPost.Id, _mapper.Map<PostDto>(newPost));
        }

        // DELETE: Api/Posts/{PostId}
        [HttpDelete("{postId:int}")]
        public async Task<IActionResult> DeletePost([FromRoute]int postId)
        {
            var post = await _postRepository.GetPostByIdAsync(postId);
            if (post == null)
            {
                return NotFound("There is nothing to delete.");
            }

            bool result = await _postRepository.DeletePostAsync(postId);
            if (result)
            {
                return Ok("Post Deleted.");
            }

            return Ok("Post not deleted.");
        }

        // GET: Api/Posts/{PostId}
        // Route will only match if postId can be casted as a int
        [HttpGet]
        [Route("{postId:int}")]
        public async Task<IActionResult> GetPostByIdAsync(int postId)
        {
            Post postFromRepository = await _postRepository.GetPostByIdAsync(postId);
            Log.Information("Post from Repository when getting post by id: {@0}", postFromRepository);
            if (postFromRepository == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PostDto>(postFromRepository));
        }

        // GET: Api/Posts[category = string &| searchQuery = string]
        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetPostsAsync([FromQuery]PaginationResourceParameter<Post> paginationResourceParameter)
        {
            var result = await _postRepository.GetPostsAsync(paginationResourceParameter);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PATCH: Api/Posts/{PostId}
        [HttpPatch("{postId:int}", Name = "{postId:int}")]
        public async Task<IActionResult> UpdatePost([FromRoute]int postId, [FromBody]JsonPatchDocument<Post> patchDocument)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            // Post to update
            Post oldPost = await _postRepository.GetPostByIdAsync(postId);
            string prePatchImageUrl = oldPost.ImageUrl;

            if (oldPost == null)
            {
                return NotFound();
            }
            else
            {
                patchDocument.ApplyTo(oldPost, ModelState);
                string postPatchImageUrl = oldPost.ImageUrl;

                if (!ModelState.IsValid)
                {
                    return new BadRequestObjectResult(ModelState);
                }

                // Update time
                oldPost.DateTime = DateTime.Now;

                // Replace with Imgur URL of the updated image
                if (prePatchImageUrl != postPatchImageUrl)
                {
                    oldPost.ImageUrl = await new ImgurService().Upload(oldPost.ImageUrl);
                }

                // Save
                await _postRepository.Save();

                return Ok(oldPost);
            }
        }
    }
}
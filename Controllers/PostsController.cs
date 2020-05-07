using System;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
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
        private readonly IPostLogic _postLogic;

        public PostsController(IPostRepository postRepository, IMapper mapper, IPostLogic postLogic)
        {
            _postRepository = postRepository;
            _mapper = mapper;
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
        public async Task<IActionResult> GetPostByIdAsync(int postId)
        {
            Post postFromRepository = await _postRepository.GetPostByIdAsync(postId);
            Log.Information("Post from Repository when getting post by id: {@0}", postFromRepository);
            if (postFromRepository == null)
            {
                return NotFound();
            }

            if (postFromRepository.IsDeleted)
            {
                return BadRequest();
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
        public async Task<IActionResult> UpdatePostAsync([FromRoute]int postId, [FromBody]JsonPatchDocument<Post> patchDocument)
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
                if (oldPost.IsDeleted)
                {
                    return BadRequest();
                }

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
                    oldPost.ImageUrl = await new ImageUpload().Upload(oldPost.ImageUrl);
                }

                // Save
                bool isSaved = await _postRepository.SaveAsync();

                if (!isSaved)
                {
                    return null;
                }

                // Updated post
                Post newPost = await _postRepository.GetPostByIdAsync(oldPost.Id);

                if (newPost != null)
                {
                    return Ok(_mapper.Map<PostDto>(newPost));
                }

                return NotFound();
            }
        }
    }
}
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostsController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        //POST Api/Posts
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePostAsync([FromBody]Post post)
        {
            Post newPost = await _postRepository.CreatePostAsync(post);
            return Ok(_mapper.Map<PostDto>(newPost));
        }
        //GET Api/posts
        [HttpGet]
        public IActionResult GetPost([FromQuery]PostResourceParameter postResourceParameter)
        {
            IEnumerable<Post> postFromRepository = _postRepository.GetPosts(postResourceParameter);
            if (postFromRepository == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<PostDto>>(postFromRepository));
        }
        //GET Api/Posts/{PostId}
        [HttpGet]
        // Route will only match if postId can be casted as a int
        [Route("{postId:int}")]
        public async Task<IActionResult> GetPostByIdAsync(int postId)
        {
            Post postFromRepository = await _postRepository.GetPostByIdAsync(postId);
            if (postFromRepository == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PostDto>(postFromRepository));
        }
        //PATCH Api/Posts/{postId}
        [HttpPatch("{postId:int}", Name = "{postId:int}")]
        [Authorize]
        public async Task<IActionResult> UpdatePost([FromRoute]int postId, [FromBody]JsonPatchDocument<Post> patchDocument)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            // Post to update
            Post oldPost = await _postRepository.GetPostByIdAsync(postId);
            if (oldPost == null)
            {
                return NotFound();
            }
            else
            {
                patchDocument.ApplyTo(oldPost, ModelState);

                if (!ModelState.IsValid)
                {
                    return new BadRequestObjectResult(ModelState);
                }

                // Update time
                oldPost.DateTime = DateTime.Now;

                // Save
                await _postRepository.Save();

                return Ok(oldPost);
            };
        }
        //DELETE Api/Posts/{PostId}
        [HttpDelete("{postId:int}")]  
        [Authorize]
        public async Task<IActionResult> DeletePost([FromRoute]int postId)
        {
            if (await _postRepository.DeletePost(postId))
            {
                return Ok("Post Deleted");
            }
            return NotFound("There is nothing to delete.");
        }
    }
}
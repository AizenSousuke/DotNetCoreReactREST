using AutoMapper;
using DotNetCoreReactREST.Models;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public BlogController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePostAsync([FromBody]Post post)
        {
            Post newPost = await _postRepository.CreatePostAsync(post);
            return Ok(newPost);
        }

        [HttpGet]
        public IActionResult GetPost()
        {
            IEnumerable<Post> postFromRepository = _postRepository.GetPosts();
            if (postFromRepository == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<PostDto>>(postFromRepository));
        }

        [HttpGet]
        // Route will only match if postId can be casted as a int
        [Route("post/{postId:int}")]
        public IActionResult GetPostById(int postId)
        {
            var postFromRepository = _postRepository.GetPostById(postId);
            if (postFromRepository == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PostDto>(postFromRepository));
        }

        [HttpPatch(Name = "post/{postId:int}")]
        [Route("post/{postId:int}")]
        public async Task<IActionResult> UpdatePost([FromRoute]int postId, [FromBody]Post post)
        {
            if (_postRepository.GetPostById(postId) == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(await _postRepository.UpdatePost(postId, post));
            };
        }

        [HttpDelete]
        [Route("post/{postId:int}")]
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
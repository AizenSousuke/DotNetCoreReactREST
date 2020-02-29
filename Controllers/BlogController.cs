using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.Repositories;
using AutoMapper;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController: ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public BlogController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult CreatePost([FromBody]Post post)
        {
            return Ok(_postRepository.CreatePost(post));
        }

        [HttpGet]
        public ActionResult GetPost()
        {
            IEnumerable<Post> postFromRepository = _postRepository.GetPosts;
            if (postFromRepository == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<PostDto>>(postFromRepository));
        }

        [HttpGet]
        // Route will only match if postId can be casted as a int
        [Route("post/{postId:int}")]
        public ActionResult GetPostById(int postId)
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
        public ActionResult UpdatePost([FromRoute]int postId, [FromBody]Post post)
        {
            if (_postRepository.GetPostById(postId) == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_postRepository.UpdatePost(postId, post));
            };
        }

        [HttpDelete]
        [Route("post/{postId:int}")]
        public ActionResult DeletePost([FromRoute]int postId)
        {
            if (_postRepository.DeletePost(postId))
            {
                return Ok("Post Deleted");
            }
            return NotFound("There is nothing to delete.");
        }
    }
}

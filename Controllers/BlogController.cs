using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReactREST.Repositories;

namespace DotNetCoreReactREST
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController: ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public BlogController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public IEnumerable<Post> GetPost()
        {
            return _postRepository.GetPosts;
        }

        [HttpPost]
        public ActionResult CreatePost([FromBody]Post post)
        {
            return Ok(_postRepository.CreatePost(post));
        }

        [HttpGet]
        [Route("post/{postId}")]
        public ActionResult GetPostById(int postId)
        {
            var post = _postRepository.GetPostById(postId);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(_postRepository.GetPostById(postId));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreReactREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : Controller
    {
        private ICommentRepository _commentRepo;
        public CommentsController(ICommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
        }
        // GET: api/comments
        [HttpGet]
        public ActionResult GetComments()
        {
           
        }

        // GET api/comments/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/comments
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/comments
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/comments
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

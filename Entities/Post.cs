using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();

        public static implicit operator Task<object>(Post v)
        {
            throw new NotImplementedException();
        }
    }
}

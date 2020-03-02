using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreReactREST.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}

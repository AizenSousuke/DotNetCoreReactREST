using System;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Entities
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Post> Posts { get; set; } //Post Ids for frontend
    }
}
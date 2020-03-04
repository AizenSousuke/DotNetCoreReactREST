using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Dtos
{
    public class CategoryDto
    {
        // Public facing properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}

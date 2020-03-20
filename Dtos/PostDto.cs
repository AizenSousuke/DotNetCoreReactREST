using DotNetCoreReactREST.Entities;
using System;

namespace DotNetCoreReactREST.Dtos
{
    public class PostDto
    {
        // Public Facing Properties
        public int Id { get; set; }        
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string ApplicationUserId { get; set; }


    }
}

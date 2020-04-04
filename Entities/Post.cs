﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(50000)]
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}

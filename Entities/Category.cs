using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}

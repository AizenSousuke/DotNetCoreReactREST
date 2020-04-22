using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos
{
    public abstract class CategoryForManipulationDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
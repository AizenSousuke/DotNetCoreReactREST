using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

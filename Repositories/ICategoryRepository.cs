using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        Task<ActionResult<IEnumerable<Category>>> GetCategories();
        Task<ActionResult<Category>> GetCategory(int id);
        Task<IActionResult> PutCategory(int id, Category category);
        Task<ActionResult<Category>> PostCategory(Category category);
        Task<ActionResult<Category>> DeleteCategory(int id);
        bool CategoryExists(int id);
        Task<int> SaveChangesAsync();
    }
}

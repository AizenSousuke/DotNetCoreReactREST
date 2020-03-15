using DotNetCoreReactREST.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        Task<ActionResult<IEnumerable<Category>>> GetCategories();
        Task<ActionResult<Category>> GetCategory(int id);
        Task<IActionResult> PutCategory(int id, Category category);
        Task<ActionResult<Category>> PostCategory(Category category);
        Task<int> DeleteCategory(int id);
        bool CategoryExists(int id);
        Task<int> SaveChangesAsync();
    }
}

using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool CategoryExists(int id)
        {
            return _appDbContext.Categories.Any(e => e.Id == id);
        }

        public async Task<int> DeleteCategory(int id)
        {
            if (CategoryExists(id))
            {
                _appDbContext.Categories.Remove(await _appDbContext.Categories.FirstOrDefaultAsync(p => p.Id == id));
                return await SaveChangesAsync();
            }

            return 0;
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _appDbContext.Categories.ToListAsync();
        }

        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            return await _appDbContext.Categories.FindAsync(id);
        }

        public Task<ActionResult<Category>> PostCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutCategory(int id, Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }
    }
}

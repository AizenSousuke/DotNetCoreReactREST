using System;
using System.Threading.Tasks;
using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReactREST.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCategoryAsync(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            await _context.Categories.AddAsync(category);
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            if (string.IsNullOrEmpty(categoryId.ToString()))
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            return await _context.Categories.AnyAsync(c => c.Id == categoryId);
        }

        public async Task<Category> DeleteCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            category.IsDeleted = true;
            await Save();

            Category deletedCategory = await GetCategoryById(category.Id);
            if (deletedCategory != null)
            {
                return deletedCategory;
            }

            return null;
        }

        public async Task<PaginationResourceParameter<Category>> GetCategoriesAsync(PaginationResourceParameter<Category> paginationResourceParameter)
        {
            PaginationResourceParameter<Category> result = new PaginationResourceParameter<Category>(_context);
            return await result.InitAsync(paginationResourceParameter);
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
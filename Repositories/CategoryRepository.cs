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

        public async Task<bool> CategoryNameExistsAsync(string categoryName)
        {
            // TODO: Double check following defensive programming. What are the requirements for category name? Can it be empty? Can it be only whitespaces?
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentNullException(nameof(categoryName));
            }

            return await _context.Categories.AnyAsync(c => c.Name == categoryName);
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
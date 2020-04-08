using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Add(category);
        }
        public async Task<PaginationResourceParameter<Category>> GetAllCategories(PaginationResourceParameter<Category> paginationResourceParameter)
        {
            PaginationResourceParameter<Category> result = new PaginationResourceParameter<Category>(_context);
            return await result.InitAsync(paginationResourceParameter);
        }

        public bool CategoryExists(int categoryId)
        {
            if (String.IsNullOrEmpty(categoryId.ToString()))
            {
                throw new ArgumentNullException(nameof(categoryId));
            }
            return _context.Categories.Any(c => c.Id == categoryId);
        }

        public void DeleteCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Remove(category);
        }

        public Category GetCategoryById(int categoryId)
        {
            if (String.IsNullOrWhiteSpace(categoryId.ToString()))
            {
                throw new ArgumentNullException(nameof(categoryId));
            }
            return _context.Categories
                .FirstOrDefault(c => c.Id == categoryId);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Update(category);
        }
    }
}

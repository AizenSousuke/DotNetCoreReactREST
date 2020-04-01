using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.Name).ToList();
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

﻿using DotNetCoreReactREST.DbContexts;
using DotNetCoreReactREST.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            if (string.IsNullOrEmpty(categoryId.ToString()))
            {
                throw new ArgumentNullException(nameof(categoryId));
            }
            return await _context.Categories.AnyAsync(c => c.Id == categoryId);
        }

        public void DeleteCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _context.Categories.Remove(category);            
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            if (string.IsNullOrWhiteSpace(categoryId.ToString()))
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
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

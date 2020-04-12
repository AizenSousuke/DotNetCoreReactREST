using DotNetCoreReactREST.Entities;
using System.Collections.Generic;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        bool CategoryExists(int categoryId);
        void DeleteCategory(Category category);
        Category GetCategoryById(int categoryId);
        bool Save();
        void UpdateCategory(Category category);
        IEnumerable<Category> GetAllCategories();

    }
}


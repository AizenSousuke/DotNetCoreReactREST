using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        Task<bool> CategoryExists(int categoryId);
        void DeleteCategory(Category category);
        Task<Category> GetCategoryById(int categoryId);
        bool Save();
        void UpdateCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();

    }
}


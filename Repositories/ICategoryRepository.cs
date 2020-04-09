using DotNetCoreReactREST.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategory(Category category);
        Task<bool> CategoryExists(int categoryId);
        void DeleteCategory(Category category);
        Task<Category> GetCategoryById(int categoryId);
        Task<bool> Save();
        void UpdateCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();

    }
}


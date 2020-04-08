using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task<PaginationResourceParameter<Category>> GetAllCategories(PaginationResourceParameter<Category> paginationResourceParameter);

    }
}


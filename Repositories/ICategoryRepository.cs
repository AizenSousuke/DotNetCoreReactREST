using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategory(Category category);

        Task<bool> CategoryExists(int categoryId);

        Task<Category> DeleteCategory(Category category);

        Task<PaginationResourceParameter<Category>> GetAllCategories(PaginationResourceParameter<Category> paginationResourceParameter);

        Task<Category> GetCategoryById(int categoryId);

        Task<bool> Save();

        void UpdateCategory(Category category);
    }
}
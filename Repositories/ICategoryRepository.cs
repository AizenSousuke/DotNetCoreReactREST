using System.Threading.Tasks;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);

        Task<bool> CategoryNameExistsAsync(string categoryName);

        Task<PaginationResourceParameter<Category>> GetCategoriesAsync(PaginationResourceParameter<Category> paginationResourceParameter);

        Task<Category> GetCategoryByIdAsync(int categoryId);

        Task<bool> SaveAsync();
    }
}
using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Logic
{
    public interface ICategoryLogic
    {
        Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category);

        Task<CategoryDto> DeleteCategoryAsync(int categoryId);

        Task<CategoryDto> EditCategoryAsync(int categoryId, CategoryForUpdateDto categoryPatchDetails);

        Task<PaginationResourceParameter<Category>> GetCategoriesAsync(PaginationResourceParameter<Category> paginationResourceParameter);

        Task<CategoryDto> GetCategoryAsync(int categoryId);
    }
}
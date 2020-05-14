using System;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;

namespace DotNetCoreReactREST.Logic
{
    public class CategoryLogic : ICategoryLogic
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryLogic(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryForCreationDto category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            // TODO: What to return when category exists
            // Check if category name exists
            bool nameExists = await _categoryRepository.CategoryNameExistsAsync(category.Name);
            if (nameExists)
            {
                // Abort creating new category
                return null;
            }

            // Category does not already exist, continue
            // Map DTO to Entity
            Category categoryToAdd = _mapper.Map<Category>(category);

            // Add category
            await _categoryRepository.AddCategoryAsync(categoryToAdd);

            // Save
            bool isSaved = await _categoryRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            // Return converted Entity to DTO category
            return _mapper.Map<CategoryDto>(categoryToAdd);
        }

        public async Task<CategoryDto> DeleteCategoryAsync(int categoryId)
        {
            // Get category
            Category categoryToDelete = await _categoryRepository.GetCategoryByIdAsync(categoryId);

            if (categoryToDelete == null)
            {
                return null;
            }

            // Soft delete
            categoryToDelete.IsDeleted = true;

            // Save
            bool isSaved = await _categoryRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            // Return converted Entity to DTO category
            return _mapper.Map<CategoryDto>(categoryToDelete);
        }

        public async Task<CategoryDto> EditCategoryAsync(int categoryId, CategoryForUpdateDto categoryPatchDetails)
        {
            // Get category
            Category categoryFromRepo = await _categoryRepository.GetCategoryByIdAsync(categoryId);

            if (categoryFromRepo == null)
            {
                return null;
            }

            // Undelete when deleted category is edited
            if (categoryFromRepo.IsDeleted)
            {
                categoryFromRepo.IsDeleted = false;
            }

            // Apply patch
            _mapper.Map(categoryPatchDetails, categoryFromRepo);

            // Save
            bool isSaved = await _categoryRepository.SaveAsync();

            if (!isSaved)
            {
                return null;
            }

            // Return converted Entity to DTO category
            return _mapper.Map<CategoryDto>(categoryFromRepo);
        }

        public async Task<PaginationResourceParameter<Category>> GetCategoriesAsync(PaginationResourceParameter<Category> paginationResourceParameter)
        {
            return await _categoryRepository.GetCategoriesAsync(paginationResourceParameter);
        }

        public async Task<CategoryDto> GetCategoryAsync(int categoryId)
        {
            // Get category
            Category categoryFromRepo = await _categoryRepository.GetCategoryByIdAsync(categoryId);

            if (categoryFromRepo == null || categoryFromRepo.IsDeleted)
            {
                return null;
            }

            // Return converted Entity to DTO category
            return _mapper.Map<CategoryDto>(categoryFromRepo);
        }
    }
}
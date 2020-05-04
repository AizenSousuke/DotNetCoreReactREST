using System;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreReactREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        // POST: Api/Categories
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> CreateCategory(CategoryForCreationDto category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            var categoryToAdd = _mapper.Map<Category>(category);
            await _categoryRepository.AddCategoryAsync(categoryToAdd);

            var isSaved = await _categoryRepository.SaveAsync();
            if (!isSaved)
            {
                return Problem("Problem saving newly created category.");
            }

            // Alternative way
            // var baseURI = Request.Scheme + "://" + Request.Host + Request.Path;
            var baseURI = Request.GetDisplayUrl();

            return Created(baseURI + categoryToAdd.Id, _mapper.Map<CategoryDto>(categoryToAdd));
        }

        // DELETE: Api/Categories/{CategoryId}
        [HttpDelete("{categoryId}")]
        public async Task<ActionResult> DeleteCategory(int categoryId)
        {
            var categoryToDelete = await _categoryRepository.GetCategoryByIdAsync(categoryId);
            if (categoryToDelete == null)
            {
                return BadRequest("Category does not exists");
            }

            _categoryRepository.DeleteCategory(categoryToDelete);
            await _categoryRepository.SaveAsync();

            return NoContent();
        }

        // PATCH: Api/Categories/{CategoryId}
        [HttpPatch("{categoryId}")]
        public async Task<ActionResult<CategoryDto>> EditCategory(int categoryId, CategoryForUpdateDto category)
        {
            var categoryFromRepo = await _categoryRepository.GetCategoryByIdAsync(categoryId);
            if (categoryFromRepo == null)
            {
                return BadRequest("Category does not exists");
            }

            _mapper.Map(category, categoryFromRepo);
            await _categoryRepository.SaveAsync();

            return NoContent();
        }

        // GET: Api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories([FromQuery] PaginationResourceParameter<Category> paginationResourceParameter)
        {
            var result = await _categoryRepository.GetCategoriesAsync(paginationResourceParameter);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: Api/Categories/{CategoryId}
        [HttpGet("{categoryId}", Name = "GetCategories")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int categoryId)
        {
            var categoryFromRepo = await _categoryRepository.GetCategoryByIdAsync(categoryId);

            if (categoryFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDto>(categoryFromRepo));
        }
    }
}
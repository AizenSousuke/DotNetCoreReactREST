using System.Threading.Tasks;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Logic;
using DotNetCoreReactREST.ResourceParameters;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreReactREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryLogic _categoryLogic;

        public CategoriesController(ICategoryLogic categoryLogic)
        {
            _categoryLogic = categoryLogic;
        }

        // POST: api/categories
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> CreateCategory(CategoryForCreationDto category)
        {
            CategoryDto addedCategory = await _categoryLogic.CreateCategoryAsync(category);

            if (addedCategory == null)
            {
                return Problem();
            }

            // Alternative way
            // var baseURI = Request.Scheme + "://" + Request.Host + Request.Path;
            var baseURI = Request.GetDisplayUrl();

            return Created(baseURI + addedCategory.Id, addedCategory);
        }

        // DELETE: api/categories/{categoryId}
        [HttpDelete("{categoryId}")]
        public async Task<ActionResult> DeleteCategory(int categoryId)
        {
            CategoryDto deletedCategory = await _categoryLogic.DeleteCategoryAsync(categoryId);

            if (deletedCategory == null)
            {
                return Problem();
            }

            return Ok(deletedCategory);
        }

        // PATCH: api/categories/{categoryId}
        [HttpPatch("{categoryId}")]
        public async Task<ActionResult> EditCategory(int categoryId, CategoryForUpdateDto category)
        {
            CategoryDto result = await _categoryLogic.EditCategoryAsync(categoryId, category);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/categories
        [HttpGet]
        public async Task<ActionResult> GetCategories([FromQuery] PaginationResourceParameter<Category> paginationResourceParameter)
        {
            PaginationResourceParameter<Category> result = await _categoryLogic.GetCategoriesAsync(paginationResourceParameter);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/categories/{categoryId}
        [HttpGet("{categoryId}", Name = "GetCategories")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int categoryId)
        {
            CategoryDto result = await _categoryLogic.GetCategoryAsync(categoryId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
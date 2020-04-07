using AutoMapper;
using DotNetCoreReactREST.Dtos;
using DotNetCoreReactREST.Entities;
using DotNetCoreReactREST.Repositories;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        // GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categoriesFromRepo = await _categoryRepository.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categoriesFromRepo));
        }

        // GET: api/Categories/5
        [HttpGet("{categoryId}", Name = "GetCategories")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int categoryId)
        {
            var categoryFromRepo = await _categoryRepository.GetCategoryById(categoryId);

            if (categoryFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDto>(categoryFromRepo));
        }

        [HttpPut("{categoryId}")]
        public async Task<ActionResult<CategoryDto>> EditCategory(int categoryId, CategoryForUpdateDto category)
        {
            var categoryFromRepo = await _categoryRepository.GetCategoryById(categoryId);
            if (categoryFromRepo == null)
            {
                return BadRequest();
            }
            _mapper.Map(category, categoryFromRepo);
            _categoryRepository.Save();

            return NoContent();
        }

        [HttpPost]
        public ActionResult<CategoryDto> CreateCategory(CategoryForCreationDto category)
        {
            var categoryToAdd = _mapper.Map<Category>(category);
            _categoryRepository.AddCategory(categoryToAdd);
            _categoryRepository.Save();


            var baseURI = Request.GetDisplayUrl();
            // Alternative way
            // var baseURI = Request.Scheme + "://" + Request.Host + Request.Path;
            return Created(baseURI + categoryToAdd.Id, _mapper.Map<CategoryDto>(categoryToAdd));
        }

        // DELETE: api/Categories/5
        [HttpDelete("{categoryId}")]
        public async Task<ActionResult> DeleteCategory(int categoryId)
        {
            var categoryToDelete = await _categoryRepository.GetCategoryById(categoryId);
            if (categoryToDelete == null)
            {
                BadRequest();
            }
            _categoryRepository.DeleteCategory(categoryToDelete);
            _categoryRepository.Save();

            return NoContent();
        }


    }
}

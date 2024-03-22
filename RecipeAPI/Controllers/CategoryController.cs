using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            if (id == null) return BadRequest();
            var output = _categoryService.GetCategory(id);
            return Ok(output);
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var output = _categoryService.GetAllCategories();
            return Ok(output);
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryCreateDTO category)
        {
            if (category == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(category);
            }
            _categoryService.CreateCategory(category);
            return Ok("Category created.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.DeleteCategory(id);
            return Ok("Category deleted.");
        }
        [HttpPut]
        public IActionResult UpdateCategory(CategoryUpdateDTO category)
        {
            if (category == null) return BadRequest("Invalid data.");
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(category);
            }
            _categoryService.UpdateCategory(category);
            return Ok("Category updated.");
        }

    }
}

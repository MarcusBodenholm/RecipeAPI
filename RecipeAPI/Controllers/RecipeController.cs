using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Models.DTO;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        [HttpGet("{id}")]
        public IActionResult GetRecipe(int id)
        {
            var recipe = _recipeService.GetRecipe(id);
            return Ok(recipe);
        }
        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            var recipes = _recipeService.GetAllRecipes();
            return Ok(recipes);
        }
        [HttpGet]
        [Route("/user/{userid}/recipes")]
        public IActionResult GetAllRecipesForUser(int userid)
        {
            if (userid == null) return BadRequest("Invalid data.");
            var recipes = _recipeService.GetAllRecipesForUser(userid);
            return Ok(recipes);
        }
        [HttpPost]
        public IActionResult CreateRecipe(RecipeCreateDTO recipe)
        {
            if (recipe == null) return BadRequest("Invalid data.");
            _recipeService.CreateRecipe(recipe);
            return Ok("Recipe created.");
        }
        [HttpPut()]
        public IActionResult UpdateRecipe(RecipeUpdateDTO recipe)
        {
            if (recipe == null) return BadRequest("Invalid data.");
            _recipeService.UpdateRecipe(recipe);
            return Ok("Recipe updated.");

        }
        [HttpDelete]
        public IActionResult DeleteRecipe(RecipeDeleteDTO recipe)
        {
            if (recipe == null) return BadRequest("Invalid data.");
            _recipeService.DeleteRecipe(recipe);
            return Ok("Recipe deleted.");

        }
    }
}

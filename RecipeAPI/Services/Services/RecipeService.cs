using RecipeAPI.Models.Entities;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepo _recipeRepo;

        public RecipeService(IRecipeRepo recipeRepo)
        {
            _recipeRepo = recipeRepo;
        }
        public void CreateRecipe(Recipe recipe)
        {
            _recipeRepo.CreateRecipe(recipe);
        }
        public Recipe? GetRecipe(int id)
        {
            Recipe? recipe = _recipeRepo.GetRecipe(id, false);
            return recipe;
        }
        public List<Recipe> GetAllRecipes()
        {
            var result = _recipeRepo.GetAllRecipes();
            return result;
        }
        public void DeleteRecipe(Recipe recipe)
        {
            //Need to add logic to check if the
            //deleting user was the one who created the recipe. 
            Recipe? toDelete = _recipeRepo.GetRecipe(recipe.Id, true);
            if (toDelete != null)
            {
                _recipeRepo.DeleteRecipe(toDelete);
            }
        }
        public void UpdateRecipe(Recipe recipe)
        {
            //Need to add logic to check if the
            //updating user was the one who created the recipe. 

            Recipe toUpdate = _recipeRepo.GetRecipe(recipe.Id, true);
            if (toUpdate != null)
            {
                toUpdate.Description = recipe.Description;
                toUpdate.CreatedBy = recipe.CreatedBy;
                toUpdate.Title = recipe.Title;
                toUpdate.Category = recipe.Category;
                toUpdate.Ingredients = recipe.Ingredients;
                _recipeRepo.UpdateRecipe();
            }
        }
    }
}

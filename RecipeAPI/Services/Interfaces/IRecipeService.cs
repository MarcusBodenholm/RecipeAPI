using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IRecipeService
    {
        public void CreateRecipe(Recipe recipe);
        public Recipe? GetRecipe(int id);
        public List<Recipe> GetAllRecipes();
        public void DeleteRecipe(Recipe recipe);
        public void UpdateRecipe(Recipe recipe);
    }
}

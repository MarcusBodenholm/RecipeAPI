using RecipeAPI.Models.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface IRecipeRepo
    {
        public void CreateRecipe(Recipe recipe);
        public Recipe? GetRecipe(int id, bool tracking);
        public List<Recipe> GetAllRecipes();
        public void DeleteRecipe(Recipe toDelete);
        public void UpdateRecipe();
    }
}

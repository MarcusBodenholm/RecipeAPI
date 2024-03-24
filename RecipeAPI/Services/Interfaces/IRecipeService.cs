using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IRecipeService
    {
        public void CreateRecipe(RecipeCreateDTO recipe);
        public RecipeDTO? GetRecipe(int id);
        public List<RecipeDTO> GetAllRecipes();
        public List<RecipeDTO> GetAllRecipesForUser(int userId);
        public void DeleteRecipe(RecipeDeleteDTO recipe);
        public void UpdateRecipe(RecipeUpdateDTO recipe);
        public List<RecipeDTO> SearchRecipes(string search);
    }
}

using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Entities;
using RecipeAPI.Repository.Interfaces;

namespace RecipeAPI.Repository.Repos
{
    public class RecipeRepo : IRecipeRepo
    {
        private readonly RecipeDBContext _dbContext;
        public RecipeRepo(RecipeDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void CreateRecipe(Recipe recipe)
        {
            _dbContext.Recipes.Add(recipe);
            _dbContext.SaveChanges();
        }
        public Recipe GetRecipe(int id)
        {
            Recipe recipe = _dbContext.Recipes.FirstOrDefault(r => r.Id == id);
            return recipe;
        }
        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> recipes = _dbContext.Recipes.ToList();
            return recipes;
        }
        public void DeleteRecipe(Recipe toDelete)
        {
            _dbContext.Recipes.Remove(toDelete);
            _dbContext.SaveChanges();
        }
        public void UpdateRecipe()
        {
            _dbContext.SaveChanges();
        }
    }
}

using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Models.Exceptions;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepo _recipeRepo;
        private readonly IUserRepo _userRepo;
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public RecipeService(IRecipeRepo recipeRepo, IMapper mapper, IUserRepo userRepo, ICategoryRepo categoryRepo)
        {
            _recipeRepo = recipeRepo;
            _mapper = mapper;
            _userRepo = userRepo;
            _categoryRepo = categoryRepo;
        }
        public void CreateRecipe(RecipeCreateDTO recipe)
        {
            User createdBy = _userRepo.GetUser(recipe.CreatedByID, true);
            if (createdBy == null)
            {
                throw new UserNotFoundException(recipe.CreatedByID);
            }
            Category category = _categoryRepo.GetCategory(recipe.CategoryID, true);
            if (category == null)
            {
                throw new CategoryNotFoundException(recipe.CategoryID);
            }
            Recipe newRecipe = _mapper.Map<Recipe>(recipe);
            newRecipe.Category = category;
            newRecipe.CreatedBy = createdBy;
            _recipeRepo.CreateRecipe(newRecipe);
        }
        public RecipeDTO? GetRecipe(int id)
        {
            Recipe? recipe = _recipeRepo.GetRecipe(id, false);
            if (recipe == null)
            {
                throw new RecipeNotFoundException(id);
            }
            var output = _mapper.Map<RecipeDTO>(recipe);
            return output;
        }
        public List<RecipeDTO> GetAllRecipes()
        {
            var recipes = _recipeRepo.GetAllRecipes();
            var result = recipes.Select(r => _mapper.Map<RecipeDTO>(r)).ToList();
            return result;
        }
        public List<RecipeDTO> GetAllRecipesForUser(int userId)
        {
            var recipes = _recipeRepo.GetAllRecipesForUser(userId);
            var result = recipes.Select(r => _mapper.Map<RecipeDTO>(r)).ToList();
            return result;
        }
        public void DeleteRecipe(RecipeDeleteDTO recipe)
        {
            //Need to add logic to check if the
            //deleting user was the one who created the recipe. 
            Recipe? toDelete = _recipeRepo.GetRecipe(recipe.RecipeID, true);
            if (toDelete == null)
            {
                throw new RecipeNotFoundException(recipe.RecipeID);
            }
            if (recipe.UserID != toDelete.CreatedBy.Id)
            {
                throw new UserNotAuthorizedException("You're not authorized to delete recipes you did not create.");
            }
            _recipeRepo.DeleteRecipe(toDelete);
        }
        public void UpdateRecipe(RecipeUpdateDTO recipe)
        {
            //Need to add logic to check if the
            //updating user was the one who created the recipe. 

            Recipe toUpdate = _recipeRepo.GetRecipe(recipe.Id, true);
            if (toUpdate == null)
            {
                throw new RecipeNotFoundException(recipe.Id);
            }
            if (recipe.UserID != toUpdate.CreatedBy.Id)
            {
                throw new UserNotAuthorizedException("Not allowed to edit a recipe you did not create.");
            }
            Category category = _categoryRepo.GetCategory(recipe.CategoryID, true);
            if (category == null)
            {
                throw new CategoryNotFoundException(recipe.CategoryID);
            }
            if (toUpdate != null)
            {
                toUpdate.Description = recipe.Description;
                toUpdate.Title = recipe.Title;
                toUpdate.Category = category;
                toUpdate.Ingredients = recipe.Ingredients;
                _recipeRepo.UpdateRecipe();
            }
        }
    }
}

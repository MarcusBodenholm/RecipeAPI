using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface IRatingRepo
    {
        public void CreateRating(Rating rating);
        public Rating? GetRating(int id, bool tracking);
        public List<Rating> GetRatingsForRecipe(int recipeid);
        public List<Rating> GetAllRatings();
        public void DeleteRating(Rating toDelete);
        public void UpdateRating();
        public List<Rating> GetRatingsForRecipe(Recipe recipe);
    }
}

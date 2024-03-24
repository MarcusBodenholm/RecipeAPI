using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IRatingService
    {
        public void CreateRating(RatingCreateDTO rating);
        public RatingDTO GetRating(int id);
        public List<RatingDTO> GetRatingsForRecipe(int recipeid);
        public List<RatingDTO> GetAllRatings();
        public void DeleteRating(RatingDeleteDTO rating);
        public void UpdateRating(RatingUpdateDTO rating);
        public double AverageRating(Recipe recipe);
    }
}

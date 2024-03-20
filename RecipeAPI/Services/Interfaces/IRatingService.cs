using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IRatingService
    {
        public void CreateRating(Rating rating);
        public Rating? GetRating(int id);
        public List<Rating> GetAllRatings();
        public void DeleteRating(Rating rating);
        public void UpdateRating(Rating rating);
        public double AverageRating(Recipe recipe);
    }
}

using RecipeAPI.Repository.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface IRatingRepo
    {
        public void CreateRating(Rating rating);
        public Rating? GetRating(int id);
        public List<Rating> GetAllRatings();
        public void DeleteRating(Rating toDelete);
        public void UpdateRating();

    }
}

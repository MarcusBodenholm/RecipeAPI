using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Entities;

namespace RecipeAPI.Repository.Repos
{
    public class RatingRepo
    {
        private readonly RecipeDBContext _dbContext;
        public RatingRepo(RecipeDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void CreateRating(Rating rating)
        {
            _dbContext.Ratings.Add(rating);
            _dbContext.SaveChanges();
        }
        public Rating? GetRating(int id)
        {
            Rating rating = _dbContext.Ratings.SingleOrDefault(r => r.Id == id);
            return rating;
        }
        public List<Rating> GetAllRatings()
        {
            List<Rating> ratings = _dbContext.Ratings.ToList();
            return ratings;
        }
        public void DeleteRating(Rating toDelete)
        {
            _dbContext.Ratings.Remove(toDelete);
            _dbContext.SaveChanges();
        }
        public void UpdateRating()
        {
            _dbContext.SaveChanges();
        }

    }
}

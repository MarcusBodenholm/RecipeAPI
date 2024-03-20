using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Repository.Repos
{
    public class RatingRepo : IRatingRepo
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
        public Rating? GetRating(int id, bool tracking)
        {
            Rating? rating = tracking ?
                             _dbContext.Ratings.SingleOrDefault(r => r.Id == id)
                             : 
                             _dbContext.Ratings.AsNoTracking().SingleOrDefault(r => r.Id == id);
            return rating;
        }
        public List<Rating> GetAllRatings()
        {
            List<Rating> ratings = _dbContext.Ratings.AsNoTracking().ToList();
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
        public List<Rating> GetRatingsForRecipe(Recipe recipe)
        {
            var result = _dbContext.Ratings
                        .AsNoTracking()
                        .Where(r => r.Recipe.Id == recipe.Id)
                        .ToList();
            return result;
        }
    }
}

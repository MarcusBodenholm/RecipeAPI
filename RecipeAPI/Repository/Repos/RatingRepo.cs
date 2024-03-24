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
                             _dbContext.Ratings
                                .Include(r => r.User)
                                .Include(r => r.Recipe)
                                .SingleOrDefault(r => r.Id == id)
                             : 
                             _dbContext.Ratings
                                .Include(r => r.User)
                                .Include(r => r.Recipe)
                                .AsNoTracking().SingleOrDefault(r => r.Id == id);
            return rating;
        }
        public List<Rating> GetRatingsForRecipe(int recipeid)
        {
            List<Rating> ratings = _dbContext.Ratings
                .Include(r => r.User)
                .Include(r => r.Recipe)
                .AsNoTracking()
                .Where(r => r.Recipe.Id == recipeid)
                .ToList();
            return ratings;
        }
        public List<Rating> GetAllRatings()
        {
            List<Rating> ratings = _dbContext.Ratings.Include(r => r.User)
                .Include(r => r.Recipe)
                .AsNoTracking()
                .ToList();
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
                .Include(r => r.User)
                .Include(r => r.Recipe)
                .AsNoTracking()
                .Where(r => r.Recipe.Id == recipe.Id)
                .ToList();
            return result;
        }
    }
}

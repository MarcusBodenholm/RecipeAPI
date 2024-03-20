using RecipeAPI.Models.Entities;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepo _ratingRepo;

        public RatingService(IRatingRepo ratingRepo)
        {
            _ratingRepo = ratingRepo;
        }
        public void CreateRating(Rating rating)
        {
            //Need to add logic to check if the
            //rating user didn't create the recipe. 
            _ratingRepo.CreateRating(rating);
        }
        public Rating? GetRating(int id)
        {
            Rating? rating = _ratingRepo.GetRating(id, false);
            return rating;
        }
        public List<Rating> GetAllRatings()
        {
            var result = _ratingRepo.GetAllRatings();
            return result;
        }
        public void DeleteRating(Rating rating)
        {
            //Need to add logic to check if the
            //deleting user was the one who created the rating. 
            Rating? toDelete = _ratingRepo.GetRating(rating.Id, true);
            if (toDelete != null)
            {
                _ratingRepo.DeleteRating(toDelete);
            }
        }
        public void UpdateRating(Rating rating)
        {
            //Need to add logic to check if the
            //updating user was the one who created the rating. 

            Rating? toUpdate = _ratingRepo.GetRating(rating.Id, true);
            if (toUpdate != null)
            {
                toUpdate.Recipe = rating.Recipe;
                toUpdate.Value = rating.Value;
                toUpdate.User = rating.User;
                _ratingRepo.UpdateRating();
            }
        }
        public double AverageRating(Recipe recipe)
        {
            var ratings = _ratingRepo.GetRatingsForRecipe(recipe);
            double result = ratings.Average(rating => rating.Value);
            return result;
        }
    }
}

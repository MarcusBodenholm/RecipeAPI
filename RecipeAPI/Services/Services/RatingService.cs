using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Models.Exceptions;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepo _ratingRepo;
        private readonly IMapper _mapper;
        private readonly IRecipeRepo _recipeRepo;
        private readonly IUserRepo _userRepo;

        public RatingService(IRatingRepo ratingRepo, IMapper mapper, IRecipeRepo recipeRepo, IUserRepo userRepo)
        {
            _ratingRepo = ratingRepo;
            _mapper = mapper;
            _recipeRepo = recipeRepo;
            _userRepo = userRepo;
        }
        public void CreateRating(RatingCreateDTO rating)
        {
            Recipe? recipe = _recipeRepo.GetRecipe(rating.RecipeID, true);
            if (recipe == null)
            {
                throw new RecipeNotFoundException(rating.RecipeID);
            }
            if (recipe.CreatedBy.Id == rating.CreatedByID)
            {
                throw new UserNotAuthorizedException("You cannot create a rating for your own recipe.");
            }
            User? user = _userRepo.GetUser(rating.CreatedByID, true);
            if (user == null)
            {
                throw new UserNotFoundException(rating.CreatedByID);
            }
            Rating newRating = _mapper.Map<Rating>(rating);
            newRating.User = user;
            newRating.Recipe = recipe;
            _ratingRepo.CreateRating(newRating);
        }
        public RatingDTO GetRating(int id)
        {
            Rating? rating = _ratingRepo.GetRating(id, false);
            if (rating == null)
            {
                throw new RatingNotFoundException(id);
            }
            var result = _mapper.Map<RatingDTO>(rating);
            return result;
        }
        public List<RatingDTO> GetAllRatings()
        {
            var ratings = _ratingRepo.GetAllRatings();
            var result = ratings.Select(r => _mapper.Map<RatingDTO>(r)).ToList();
            return result;
        }
        public void DeleteRating(RatingDeleteDTO rating)
        {
            Rating? toDelete = _ratingRepo.GetRating(rating.RatingID, true);
            if (toDelete == null)
            {
                throw new RatingNotFoundException(rating.RatingID);
            }
            if (toDelete.User.Id != rating.UserID)
            {
                throw new UserNotAuthorizedException("Only the creator of the rating can remove it.");
            }
            _ratingRepo.DeleteRating(toDelete);
        }
        public void UpdateRating(RatingUpdateDTO rating)
        {
            Rating? toUpdate = _ratingRepo.GetRating(rating.RatingID, true);
            if (toUpdate == null)
            {
                throw new RatingNotFoundException(rating.RatingID);
            }
            if (toUpdate.User.Id != rating.CreatedByID)
            {
                throw new UserNotAuthorizedException("Only the creator of the rating can update it.");
            }

            toUpdate.Value = rating.Value;
            _ratingRepo.UpdateRating();
        }
        public double AverageRating(Recipe recipe)
        {
            var ratings = _ratingRepo.GetRatingsForRecipe(recipe);
            double result = ratings.Average(rating => rating.Value);
            return result;
        }
    }
}

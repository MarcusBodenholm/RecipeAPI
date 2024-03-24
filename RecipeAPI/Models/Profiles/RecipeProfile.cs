using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Models.Profiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<Recipe, RecipeDTO>()
                .ForMember(destination => destination.RecipeID,
                option => option.MapFrom(recipe => recipe.Id))
                .ForMember(destination => destination.Title,
                option => option.MapFrom(recipe => recipe.Title))
                .ForMember(destination => destination.Description,
                option => option.MapFrom(recipe => recipe.Description))
                .ForMember(destination => destination.Ingredients,
                option => option.MapFrom(recipe => recipe.Ingredients))
                .ForMember(destination => destination.AverageRating,
                option => option.MapFrom(recipe => recipe.AverageRating()))
                .ForMember(destination => destination.NumberOfRatings,
                option => option.MapFrom(recipe => recipe.Ratings.Count))
                .ForMember(destination => destination.Category,
                option => option.MapFrom(recipe => recipe.Category.CategoryName))
                .ForMember(destination => destination.CreatedBy,
                option => option.MapFrom(recipe => recipe.CreatedBy.Username));

            CreateMap<RecipeCreateDTO, Recipe>()
                .ForMember(destination => destination.Title,
                option => option.MapFrom(recipe => recipe.Title))
                .ForMember(destination => destination.Description,
                option => option.MapFrom(recipe => recipe.Description))
                .ForMember(destination => destination.Ingredients,
                option => option.MapFrom(recipe => recipe.Ingredients));
        }
    }
}

using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Models.Profiles
{
    public class RatingProfile : Profile
    {
        public RatingProfile()
        {
            CreateMap<Rating, RatingDTO>()
                .ForMember(destination => destination.RatingValue,
                option => option.MapFrom(src => src.Value))
                .ForMember(destination => destination.RatingID,
                option => option.MapFrom(src => src.Id))
                .ForMember(destination => destination.RecipeTitle,
                option => option.MapFrom(src => src.Recipe.Title))
                .ForMember(destination => destination.RecipeID,
                option => option.MapFrom(src => src.Recipe.Id))
                .ForMember(destination => destination.CreatedBy,
                option => option.MapFrom(src => src.User.Username))
                .ForMember(destination => destination.CreatedByID,
                option => option.MapFrom(src => src.User.Id));
            CreateMap<RatingCreateDTO, Rating>()
                .ForMember(destination => destination.Value,
                option => option.MapFrom(src => src.Value));

        }
    }
}

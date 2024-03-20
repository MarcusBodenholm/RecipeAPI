using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        { 
            CreateMap<UserCreateDTO, User>()
                .ForMember(destination => destination.Username,
                option => option.MapFrom(src => src.Username))
                .ForMember(destination => destination.Email,
                option => option.MapFrom(src => src.Email))
                .ForMember(destination => destination.Password,
                option => option.MapFrom(src => src.Password));
        }
    }
}

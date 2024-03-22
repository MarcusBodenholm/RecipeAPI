using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Models.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>()
                .ForMember(destination => destination.CategoryID,
                option => option.MapFrom(src => src.Id))
                .ForMember(destination => destination.CategoryName,
                option => option.MapFrom(src => src.CategoryName));
            CreateMap<CategoryCreateDTO, Category>()
                .ForMember(destination => destination.CategoryName,
                option => option.MapFrom(src => src.CategoryName));

        }
    }
}

using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        public void CreateCategory(CategoryCreateDTO category);
        public CategoryDTO? GetCategory(int id);
        public List<CategoryDTO> GetAllCategories();
        public void DeleteCategory(int id);
        public void UpdateCategory(CategoryUpdateDTO category);
    }
}

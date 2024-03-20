using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        public void CreateCategory(Category category);
        public Category? GetCategory(int id);
        public List<Category> GetAllCategories();
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category);
    }
}

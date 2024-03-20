using RecipeAPI.Models.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface ICategoryRepo
    {
        public void CreateCategory(Category category);
        public Category? GetCategory(int id, bool tracking);
        public List<Category> GetAllCategories();
        public void DeleteCategory(Category toDelete);
        public void UpdateCategory();
    }
}

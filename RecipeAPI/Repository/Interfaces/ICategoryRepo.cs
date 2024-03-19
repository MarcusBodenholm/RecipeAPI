using RecipeAPI.Repository.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface ICategoryRepo
    {
        public void CreateCategory(Category category);
        public Category? GetCategory(int id);
        public List<Category> GetAllCategories();
        public void DeleteCategory(Category toDelete);
        public void UpdateCategory();
    }
}

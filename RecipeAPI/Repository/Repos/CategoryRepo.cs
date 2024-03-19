using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Entities;
using RecipeAPI.Repository.Interfaces;

namespace RecipeAPI.Repository.Repos
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly RecipeDBContext _dbContext;
        public CategoryRepo(RecipeDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }
        public Category? GetCategory(int id)
        {
            Category category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            return category;
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = _dbContext.Categories.ToList();
            return categories;
        }
        public void DeleteCategory(Category toDelete)
        {
            _dbContext.Categories.Remove(toDelete);
            _dbContext.SaveChanges();
        }
        public void UpdateCategory() 
        {
            _dbContext.SaveChanges();
        }
    }
}

using RecipeAPI.Repository.Entities;
using RecipeAPI.Repository.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public void CreateCategory(Category category)
        {
            _categoryRepo.CreateCategory(category);
        }
        public Category? GetCategory(int id)
        {
            Category? category = _categoryRepo.GetCategory(id);
            return category;
        }
        public List<Category> GetAllCategories()
        {
            var result = _categoryRepo.GetAllCategories();
            return result;
        }
        public void DeleteCategory(Category category)
        {
            Category? toDelete = _categoryRepo.GetCategory(category.Id);
            if (toDelete != null)
            {
                _categoryRepo.DeleteCategory(toDelete);
            }
        }
        public void UpdateCategory(Category category)
        {
            Category toUpdate = _categoryRepo.GetCategory(category.Id);
            if (toUpdate != null)
            {
                toUpdate.CategoryName = category.CategoryName;
                _categoryRepo.UpdateCategory();
            }
        }
    }
}

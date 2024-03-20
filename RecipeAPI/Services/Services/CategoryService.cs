using RecipeAPI.Models.Entities;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class CategoryService : ICategoryService
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
            Category? category = _categoryRepo.GetCategory(id, false);
            return category;
        }
        public List<Category> GetAllCategories()
        {
            var result = _categoryRepo.GetAllCategories();
            return result;
        }
        public void DeleteCategory(Category category)
        {
            Category? toDelete = _categoryRepo.GetCategory(category.Id, true);
            if (toDelete != null)
            {
                _categoryRepo.DeleteCategory(toDelete);
            }
        }
        public void UpdateCategory(Category category)
        {
            Category? toUpdate = _categoryRepo.GetCategory(category.Id, true);
            if (toUpdate != null)
            {
                toUpdate.CategoryName = category.CategoryName;
                _categoryRepo.UpdateCategory();
            }
        }
    }
}

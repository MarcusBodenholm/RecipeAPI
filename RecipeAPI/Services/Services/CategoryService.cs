using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Models.Exceptions;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }
        public void CreateCategory(CategoryCreateDTO category)
        {
            Category newCategory = _mapper.Map<Category>(category);
            _categoryRepo.CreateCategory(newCategory);
        }
        public CategoryDTO GetCategory(int id)
        {
            Category? category = _categoryRepo.GetCategory(id, false);
            if (category == null)
            {
                throw new CategoryNotFoundException(id);
            }
            var result = _mapper.Map<CategoryDTO>(category);
            return result;
        }
        public List<CategoryDTO> GetAllCategories()
        {
            var categories = _categoryRepo.GetAllCategories();
            var result = categories.Select(c => _mapper.Map<CategoryDTO>(c)).ToList();  
            return result;
        }
        public void DeleteCategory(int id)
        {
            Category? toDelete = _categoryRepo.GetCategory(id, true);
            if (toDelete == null)
            {
                throw new CategoryNotFoundException(id);
            }
            _categoryRepo.DeleteCategory(toDelete);
        }
        public void UpdateCategory(CategoryUpdateDTO category)
        {
            Category? toUpdate = _categoryRepo.GetCategory(category.Id, true);
            if (toUpdate == null)
            {
                throw new CategoryNotFoundException(category.Id);
            }
            toUpdate.CategoryName = category.CategoryName;
            _categoryRepo.UpdateCategory();
        }
    }
}

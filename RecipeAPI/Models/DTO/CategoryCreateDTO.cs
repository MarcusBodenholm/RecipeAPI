using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class CategoryCreateDTO
    {
        [Required(ErrorMessage = "CategoryName is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the title is 50 characters.")]
        public string CategoryName { get; set; }
    }

}

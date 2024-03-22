using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class CategoryUpdateDTO
    {
        [Required(ErrorMessage = "Id is a required field.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the title is 50 characters.")]
        public string CategoryName { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class RecipeCreateDTO
    {
        [Required(ErrorMessage = "Title is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the title is 50 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the description is 500 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ingredients is a required field")]
        [MaxLength(500, ErrorMessage = "Maximum length for the ingredients is 500 characters.")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "CategoryID is a required field")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "CreatedByID is a required field")]
        public int CreatedByID { get; set; }
    }
}

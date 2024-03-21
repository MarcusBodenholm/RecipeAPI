using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RecipeAPI.Models.DTO
{
    public class RecipeDTO
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
        [Required(ErrorMessage = "Category is a required field")]
        public string Category { get; set; }
        [Required(ErrorMessage = "CreatedBy is a required field")]
        public string CreatedBy { get; set; }
        [AllowNull]
        public double? AverageRating { get; set; }
        [AllowNull]
        public int NumberOfRatings { get; set; }

    }
}

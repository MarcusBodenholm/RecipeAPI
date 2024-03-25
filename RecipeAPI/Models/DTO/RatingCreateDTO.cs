using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class RatingCreateDTO
    {
        [Required(ErrorMessage = "Value is a required field.")]
        [Range(1, 5, ErrorMessage = "The rating can only be and integer between 1-5 inclusive")]
        public int Value { get; set; }
        [Required(ErrorMessage = "CreatedByID is a required field.")]
        public int CreatedByID { get; set; }
        [Required(ErrorMessage = "RecipeID is a required field.")]
        public int RecipeID { get; set; }

    }
}

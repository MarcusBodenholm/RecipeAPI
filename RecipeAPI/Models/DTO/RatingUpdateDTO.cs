using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class RatingUpdateDTO
    {
        [Required(ErrorMessage = "RatingID is a required field.")]
        public int RatingID { get; set; }

        [Required(ErrorMessage = "Value is a required field.")]
        [Range(1, 5, ErrorMessage = "The rating can only be and integerbetween 1-5 inclusive")]
        public int Value { get; set; }
        [Required(ErrorMessage = "CreatedByID is a required field.")]
        public int CreatedByID { get; set; }

    }
}

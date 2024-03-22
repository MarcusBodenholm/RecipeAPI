using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class RatingDeleteDTO
    {
        [Required(ErrorMessage = "RatingID is a required field.")]
        public int RatingID { get; set; }

        [Required(ErrorMessage = "UserID is a required field.")]
        public int UserID { get; set; }

    }
}

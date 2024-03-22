using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class RecipeDeleteDTO
    {
        [Required(ErrorMessage = "RecipeID is a required field")]
        public int RecipeID { get; set; }
        [Required(ErrorMessage = "UserID is a required field")]
        public int UserID { get; set; }

    }
}

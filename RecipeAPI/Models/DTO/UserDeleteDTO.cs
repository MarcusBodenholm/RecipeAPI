using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class UserDeleteDTO
    {
        [Required(ErrorMessage = "Id is a required field.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Password is a required field")]
        [MaxLength(50, ErrorMessage = "Maximum length for the password is 50 characters.")]
        public string Password { get; set; }
    }
}

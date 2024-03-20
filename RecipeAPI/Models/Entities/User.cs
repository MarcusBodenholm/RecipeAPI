using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace RecipeAPI.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [AllowNull]
        [JsonIgnore]
        public virtual ICollection<Recipe> Recipes { get; set; }
        [AllowNull]
        [JsonIgnore]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}

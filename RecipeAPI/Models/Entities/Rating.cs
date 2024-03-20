using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RecipeAPI.Models.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public int Value { get; set; }
        public virtual User User { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}

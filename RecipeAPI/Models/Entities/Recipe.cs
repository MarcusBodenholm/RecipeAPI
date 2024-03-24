using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RecipeAPI.Models.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Ingredients { get; set; }
        [Required]
        public virtual User CreatedBy { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public Double? AverageRating()
        {
            return Ratings.Count == 0 ? 0 : Math.Round(Ratings.AsEnumerable().Average(r => r.Value), 2);
        }
    }
}

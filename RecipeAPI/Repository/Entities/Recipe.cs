using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Repository.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public virtual User CreatedBy { get; set; }

        public virtual List<Rating> Ratings { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Repository.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1,5)]
        public int Value {  get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual Recipe Recipe { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecipeAPI.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [JsonIgnore]
        public virtual List<Recipe> Recipes { get; set; }
    }
}

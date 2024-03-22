namespace RecipeAPI.Models.DTO
{
    public class RatingDTO
    {
        public int RatingID { get; set; }
        public int RatingValue { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedByID { get; set; }
        public int RecipeID { get; set; }
        public string RecipeTitle { get; set; }
    }
}

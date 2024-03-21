namespace RecipeAPI.Models.Exceptions
{
    public class RatingNotFoundException : NotFoundException
    {
        public RatingNotFoundException(int id)
            : base($"Rating with id: {id} doesn't exist in the database.")
        {

        }
    }
}

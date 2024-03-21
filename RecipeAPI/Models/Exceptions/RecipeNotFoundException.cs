namespace RecipeAPI.Models.Exceptions
{
    public class RecipeNotFoundException : NotFoundException
    {
        public RecipeNotFoundException(int id)
            : base($"Recipe with id: {id} doesn't exist in the database.")
        {

        }
    }
}

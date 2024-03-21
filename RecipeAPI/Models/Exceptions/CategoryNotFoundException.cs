namespace RecipeAPI.Models.Exceptions
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(int id)
            : base($"Category with id: {id} doesn't exit in the database.")
        {

        }
    }
}

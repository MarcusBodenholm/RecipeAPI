namespace RecipeAPI.Models.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(int id)
            : base($"User with id: {id} doesn't exist in the database.")
        {

        }
    }
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(int id)
            : base($"Category with id: {id} doesn't exit in the database.")
        {

        }
    }
    public class RatingNotFoundException : NotFoundException
    {
        public RatingNotFoundException(int id)
            : base($"Rating with id: {id} doesn't exist in the database.")
        {

        }
    }
    public class RecipeNotFoundException : NotFoundException
    {
        public RecipeNotFoundException(int id)
            : base($"Recipe with id: {id} doesn't exist in the database.")
        {

        }
    }
}

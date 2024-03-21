namespace RecipeAPI.Models.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(int id)
            : base($"User with id: {id} doesn't exist in the database.")
        {

        }
    }
}

namespace RecipeAPI.Models.Exceptions
{
    public class UserNotAuthorizedException : UnauthorizedException
    {
        public UserNotAuthorizedException(string message)
            : base(message)
        {

        }
    }
}

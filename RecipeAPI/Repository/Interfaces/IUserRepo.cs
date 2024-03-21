using RecipeAPI.Models.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface IUserRepo
    {
        public void CreateUser(User user);
        public User? GetUser(int id, bool tracking);
        public User? GetUserByUsername(string username, bool tracking);
        public List<User> GetAllUsers();
        public void DeleteUser(User toDelete);
        public void UpdateUser();

    }
}

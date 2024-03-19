using RecipeAPI.Repository.Entities;

namespace RecipeAPI.Repository.Interfaces
{
    public interface IUserRepo
    {
        public void CreateUser(User user);
        public User? GetUser(int id);
        public List<User> GetAllUsers();
        public void DeleteUser(User toDelete);
        public void UpdateUser();
    }
}

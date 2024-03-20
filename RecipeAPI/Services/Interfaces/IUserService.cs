using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IUserService
    {
        public void CreateUser(UserCreateDTO user);
        public User? GetUser(int id);
        public List<User> GetAllUsers();
        public void DeleteUser(int id);
        public void UpdateUser(UserUpdateDTO user);
    }
}

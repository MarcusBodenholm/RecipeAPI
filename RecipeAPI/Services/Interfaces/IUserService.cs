using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;

namespace RecipeAPI.Services.Interfaces
{
    public interface IUserService
    {
        public void CreateUser(UserCreateDTO user);
        public UserDTO? GetUser(int id);
        public List<UserDTO> GetAllUsers();
        public void DeleteUser(UserDeleteDTO user);
        public void UpdateUser(UserUpdateDTO user);
        public int Login(UserLoginDTO user);
    }
}

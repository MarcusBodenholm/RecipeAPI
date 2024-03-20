using AutoMapper;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Models.Exceptions;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public void CreateUser(UserCreateDTO user)
        {
            if (user == null || user.Username.Length == 0
                || user.Password.Length == 0 || user.Email.Length == 0)
            {
                throw new Exception("Exception");
            }
            User newUser = _mapper.Map<User>(user);
            _userRepo.CreateUser(newUser);
        }
        public User? GetUser(int id)
        {
            User? user = _userRepo.GetUser(id, false);
            if (user == null)
            {
                throw new UserNotFoundException(id);
            }
            return user;
        }
        public List<User> GetAllUsers()
        {
            var result = _userRepo.GetAllUsers();
            return result;
        }
        public void DeleteUser(int id)
        {
            User? toDelete = _userRepo.GetUser(id, true);
            if (toDelete == null)
            {
                throw new UserNotFoundException(id);
            }
            _userRepo.DeleteUser(toDelete);
        }
        public void UpdateUser(UserUpdateDTO user)
        {
            User? toUpdate = _userRepo.GetUser(user.Id, true);
            if (toUpdate == null)
            {
                throw new UserNotFoundException(user.Id);
            }

            toUpdate.Email = user.Email;
            toUpdate.Password = user.Password;
            toUpdate.Username = user.Username;
            _userRepo.UpdateUser();
        }
    }
}

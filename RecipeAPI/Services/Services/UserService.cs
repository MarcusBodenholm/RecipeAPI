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
            User? exists = _userRepo.GetUserByUsername(user.Username, false);
            if (exists != null)
            {
                throw new UserNotAuthorizedException("A user by that username already exists.");
            }
            User newUser = _mapper.Map<User>(user);
            _userRepo.CreateUser(newUser);
        }
        public UserDTO? GetUser(int id)
        {
            User? user = _userRepo.GetUser(id, false);
            if (user == null)
            {
                throw new UserNotFoundException(id);
            }
            var output = _mapper.Map<UserDTO>(user);
            return output;
        }
        public List<UserDTO> GetAllUsers()
        {
            var users = _userRepo.GetAllUsers();
            var outcome = users.Select(u => _mapper.Map<UserDTO>(u)).ToList();
            return outcome;
        }
        public void DeleteUser(UserDeleteDTO user)
        {
            User? toDelete = _userRepo.GetUser(user.Id, true);
            if (toDelete == null)
            {
                throw new UserNotFoundException(user.Id);
            }
            if (toDelete.Password != user.Password)
            {
                throw new UserNotAuthorizedException("Not authorized to delete user as password was incorrect.");
            }
            _userRepo.DeleteUser(toDelete);
        }
        public void UpdateUser(UserUpdateDTO user)
        {
            User? userNameInUse = _userRepo.GetUserByUsername(user.Username, false);
            if (userNameInUse != null)
            {
                throw new UserNotAuthorizedException("That username is already in use.");
            }
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

        public int Login(UserLoginDTO user)
        {
            User? userFromDB = _userRepo.GetUserByUsername(user.Username, false);
            if (userFromDB == null || user.Password != userFromDB.Password)
            {
                throw new UserNotAuthorizedException("Either the username or the password was incorrect.");
            }
            return userFromDB.Id;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Models.DTO;
using RecipeAPI.Models.Entities;
using RecipeAPI.Services.Interfaces;
using System.Web.Http.ModelBinding;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            return Ok(user);
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        [HttpPost]
        public IActionResult CreateUser(UserCreateDTO user)
        {
            if (user == null)
            {
                return BadRequest("User object is null");
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(user);
            }
            _userService.CreateUser(user);
            return Ok("User created.");
        }
        [HttpPut]
        public IActionResult UpdateUser(UserUpdateDTO user)
        {
            if (user == null)
            {
                return BadRequest("User object is null");
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(user);
            }

            _userService.UpdateUser(user);
            return Ok("User updated.");
        }
        [HttpDelete]
        public IActionResult DeleteUser(UserDeleteDTO user)
        {
            if (user == null) return BadRequest("Invalid data.");
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(user);
            }
            _userService.DeleteUser(user);
            return Ok("User deleted.");
        }
        [HttpPost]
        [Route("/api/login")]
        public IActionResult Login(UserLoginDTO user)
        {
            if (user == null) return BadRequest("Invalid data.");
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(user);
            }
            int id = _userService.Login(user);
            return Ok($"You are now logged in with id {id}");
        }
    }
}

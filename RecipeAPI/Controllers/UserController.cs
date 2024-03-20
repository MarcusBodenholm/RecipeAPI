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
            User? user = _userService.GetUser(id);
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
            return NoContent();
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
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}

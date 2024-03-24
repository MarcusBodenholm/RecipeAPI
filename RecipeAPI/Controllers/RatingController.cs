using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Models.DTO;
using RecipeAPI.Services.Interfaces;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        [HttpGet("{id}")]
        public IActionResult GetRating(int id)
        {
            var result = _ratingService.GetRating(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("/api/[controller]/{recipeid}/ratings")]
        public IActionResult GetRatingsForRecipe(int recipeid)
        {
            var result = _ratingService.GetRatingsForRecipe(recipeid);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateRating(RatingCreateDTO rating)
        {
            if (rating == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(rating);
            }
            _ratingService.CreateRating(rating);
            return Ok("Rating created.");
        }
        [HttpPut]
        public IActionResult UpdateRating(RatingUpdateDTO rating)
        {
            if (rating == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(rating);
            }
            _ratingService.UpdateRating(rating);
            return Ok("Rating updated.");
        }
        [HttpDelete]
        public IActionResult DeleteRating(RatingDeleteDTO rating)
        {
            if (rating == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(rating);
            }
            _ratingService.DeleteRating(rating);
            return Ok("Rating deleted");
        }
    }
}

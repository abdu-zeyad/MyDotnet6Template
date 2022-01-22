using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private IFood _foodService;

        public FoodsController(IFood foodService)
        {
            _foodService = foodService;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> GetFoods()
        {
            // You should count the list ...
            var list = await _foodService.GetAll();
            return Ok(list);
        }
        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(int id)
        {
            Food course = await _foodService.GetById(id);
            return course;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            var updatedCourse = await _foodService.Update(id, food);

            return Ok(updatedCourse);
        }

        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> Post(Food food)
        {
            await _foodService.Create(food);

            // Return a 201 Header to browser
            // The body of the request will be us running GetCourse(id);
            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _foodService.Delete(id);
            return NoContent();
        }

    }
}

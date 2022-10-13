using Microsoft.AspNetCore.Mvc;
using UsedCarsListingAPI.Models;
using UsedCarsListingAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UsedCarsListingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarItemsController : ControllerBase
    {
        private ICarItemRepository _carItemRepository;

        public CarItemsController(ICarItemRepository carItemRepository)
        {
            _carItemRepository = carItemRepository;
        }

        // GET: api/<CarItemsController>
        [HttpGet]
        public async Task<IEnumerable<CarItem>> Get()
        {
            return await _carItemRepository.GetCarItems();
        }

        // GET api/<CarItemsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarItem>> Get(int id)
        {
            return await _carItemRepository.GetCarItem(id);
        }

        // POST api/<CarItemsController>
        [HttpPost]
        public async Task<ActionResult<CarItem>> PostCarItem([FromBody] CarItem carItem)
        {
            var newCarItem = await _carItemRepository.Add(carItem);
            return CreatedAtAction(nameof(Get), new { id = newCarItem.Id }, newCarItem);
        }

        // PUT api/<CarItemsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CarItem carItem)
        {
            if (id != carItem.Id)
            {
                return BadRequest();
            }

            await _carItemRepository.Update(carItem);

            return NoContent();
        }

        // DELETE api/<CarItemsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var carItemToDelete = await _carItemRepository.GetCarItem(id);

            if (carItemToDelete == null)
                return NotFound();

            await _carItemRepository.Delete(carItemToDelete.Id);
            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DatingApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarsController: ControllerBase
    {
         private readonly DataContext _context;

        public CarsController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            
            var Cars = await _context.Cars.ToListAsync();
            return Ok(Cars);
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult>  GetCar (int id)
        {

            var car =  await _context.Cars.FirstOrDefaultAsync(x =>x.Id== id);
            return Ok(car);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
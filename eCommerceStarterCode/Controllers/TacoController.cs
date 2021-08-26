using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/tacos")]
    [ApiController]
    public class TacoController : ControllerBase
    {
        private ApplicationDbContext _context;
        public TacoController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var tacosFromShop = _context.Tacos.Where(taco => taco.ShopId == id);
            return Ok(tacosFromShop);

        }
        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Taco value)
        {
            _context.Tacos.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id, [FromBody] Taco value)
        {
            var taco = _context.Tacos.FirstOrDefault(taco => taco.TacoId == id);
            taco.Name = value.Name;
            taco.Price = value.Price;
            taco.NumberOfRatings = value.NumberOfRatings;
            taco.Description = value.Description;
            taco.AverageRating = value.AverageRating;
            _context.SaveChanges();
            return Ok(taco);
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var taco = _context.Tacos.FirstOrDefault(taco => taco.TacoId == id);
            _context.Remove(taco);
            _context.SaveChanges();
            return Ok();
        }
    }
}

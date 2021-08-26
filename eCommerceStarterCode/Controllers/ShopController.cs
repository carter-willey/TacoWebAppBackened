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
    [Route("api/shops")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProductController>
        //GETS ALL PRODUCTS 
        [HttpGet]
        public IActionResult Get()
        {
            var shops = _context.Shops;
            return Ok(shops);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var specificShop = _context.Shops.FirstOrDefault(shop => shop.ShopId == id);
            return Ok(specificShop);
        }

        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Shop value)
        {
            _context.Shops.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }

    }
}

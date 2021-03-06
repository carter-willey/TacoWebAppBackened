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
    [Route("api/shophours")]
    [ApiController]
    public class ShopHoursController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ShopHoursController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var ShopHours = _context.ShopHours;
            
            return Ok(ShopHours);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ShopHours = _context.ShopHours;
            var specificStoreHours = ShopHours.Where(shop => shop.ShopId == id);
            return Ok(specificStoreHours);

        }
        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] ShopHour value)
        {
            _context.ShopHours.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id, [FromBody] ShopHour value)
        {
            var shopHour = _context.ShopHours.FirstOrDefault(fr => fr.ShopHourId == id);
            shopHour.MonOpen = value.MonOpen;
            shopHour.MonClose = value.MonClose;
            shopHour.TuesOpen = value.TuesOpen;
            shopHour.TuesClose = value.TuesClose;
            shopHour.WedOpen = value.WedOpen;
            shopHour.WedClose = value.WedClose;
            shopHour.ThursOpen = value.ThursOpen;
            shopHour.ThursClose = value.ThursClose;
            shopHour.FriOpen = value.FriOpen;
            shopHour.FriClose = value.FriClose;
            shopHour.SatOpen = value.SatOpen;
            shopHour.SatClose = value.SatClose;
            shopHour.SunOpen = value.SunOpen;
            shopHour.SunClose = value.SunClose;
            _context.SaveChanges();
            return Ok(shopHour);

        }
    }
}

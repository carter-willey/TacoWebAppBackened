using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private ApplicationDbContext _context;
        public NotificationController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET: api/<ValuesController>
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var notifications = _context.Notifications.Include(note => note.User).Include(note => note.Shop);
            return Ok(notifications);
        }

        //GET api/<ValuesController>/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var specificNotification = _context.Notifications.FirstOrDefault(noti => noti.NotificationId == id);
            return Ok(specificNotification);
        }

        // POST api/<ValuesController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Notification value)
        {
            _context.Notifications.Add(value);
            _context.SaveChanges();
            return Ok(value);

        }
    
    }
}
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
    [Route("api/[controller]")]
    [ApiController]
    public class FriendshipController : ControllerBase
    {
        private ApplicationDbContext _context;
        public FriendshipController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var friends = _context.Friendships.Where(fr => fr.UserId == User.FindFirstValue("id"));
            return Ok(friends);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(string id)
        {
            var specificFriend = _context.Friendships.Where(fr => fr.FriendId == id);
            return Ok(specificFriend);
        }

        // POST api/<ValuesController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Friendship value)
        {
            _context.Friendships.Add(value);
            _context.SaveChanges();
            return Ok(value);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id)
        {
            var friendRequest = _context.Friendships.FirstOrDefault(fr => fr.FriendshipId == id);
            friendRequest.IsPending = false;
            _context.SaveChanges();
            return Ok(friendRequest);

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult Delete(int id)
        {
            var friendRequest = _context.Friendships.FirstOrDefault(fr => fr.FriendshipId == id);
            _context.Remove(friendRequest);
            _context.SaveChanges();
            return Ok();
        }
    }
}

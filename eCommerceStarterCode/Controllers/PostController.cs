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
    public class PostController : ControllerBase
    {
        private ApplicationDbContext _context;
        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var posts = _context.Posts;
            return Ok(posts);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var specificPost = _context.Posts.FirstOrDefault(post => post.PostId == id);
            return Ok(specificPost);
        }

        // POST api/<ValuesController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Post value)
        {
            _context.Posts.Add(value);
            _context.SaveChanges();
            return Ok(value);

        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.FirstOrDefault(fr => fr.PostId == id);
            _context.Remove(post);
            _context.SaveChanges();
            return Ok();
        }
    }
}
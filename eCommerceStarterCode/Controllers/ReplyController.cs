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
    [Route("api/[controller]")]
    [ApiController]
    public class ReplyController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ReplyController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProductController>
        //GETS ALL PRODUCTS 
        [HttpGet]
        public IActionResult Get(int id)
        {
            var replies = _context.Replies.Where(reply => reply.CommentId == id);
            return Ok(replies);
        }

        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Reply value)
        {
            _context.Replies.Add(value);
            _context.SaveChanges();
            return Ok(value);
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reply = _context.Replies.FirstOrDefault(reply => reply.ReplyId == id);
            _context.Remove(reply);
            _context.SaveChanges();
            return Ok();
        }
    }
}

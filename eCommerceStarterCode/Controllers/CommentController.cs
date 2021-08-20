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
    public class CommentController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProductController>
        //GETS ALL PRODUCTS 
        [HttpGet]
        public IActionResult Get()
        {
            var comments = _context.Comments;
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var comments = _context.Comments;
            var specificComment = comments.FirstOrDefault(com => com.CommentId == id);
            return Ok(specificComment);

        }
        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Comment value)
        {
            _context.Comments.Add(value);
            var post = _context.Posts.FirstOrDefault(post => post.PostId == value.PostId);
            _context.SaveChanges();
            return Ok(value);
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var comment = _context.Comments.FirstOrDefault(com => com.CommentId == id);
            _context.Remove(comment);
            _context.SaveChanges();
            return Ok();
        }
    }
}

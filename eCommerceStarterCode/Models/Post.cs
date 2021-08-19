using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Taco")]
        public int TacoId { get; set; }
        public Taco Taco { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}

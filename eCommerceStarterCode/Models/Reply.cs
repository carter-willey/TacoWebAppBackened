using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Reply
    {
        public int ReplyId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public string Text { get; set; }
    }
}

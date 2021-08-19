using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Friendship
    {
        public int FriendshipId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Friend")]
        public string FriendId { get; set; }
        public User Friend { get; set; }
        public bool IsPending { get; set; }
    }
}

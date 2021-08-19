using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        [ForeignKey("Owner")]
        public string OwnerId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
    }
}

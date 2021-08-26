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
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "decimal(11,8)")]
        public decimal Lng { get; set; }
        [Column(TypeName = "decimal(10,8)")]
        public decimal Lat { get; set; }
        public string Image { get; set; }
    }
}

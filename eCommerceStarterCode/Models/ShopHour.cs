using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShopHour
    {
        public int ShopHourId { get; set; }
        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public int Day { get; set; }
        public int Open { get; set; }
        public int Close { get; set; }
    }
}

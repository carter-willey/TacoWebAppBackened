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
        public string MonOpen { get; set; }
        public string MonClose { get; set; }
        public string TuesOpen { get; set; }
        public string TuesClose { get; set; }
        public string WedOpen { get; set; }
        public string WedClose { get; set; }
        public string ThursOpen { get; set; }
        public string ThursClose { get; set; }
        public string FriOpen { get; set; }
        public string FriClose { get; set; }
        public string SatOpen { get; set; }
        public string SatClose { get; set; }
        public string SunOpen { get; set; }
        public string SunClose { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Taco
    {
        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal AverageRating { get; set; }
        public int NumberOfRatings { get; set; }
    }
}

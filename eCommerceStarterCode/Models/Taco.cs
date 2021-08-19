using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Taco
    {
        public int TacoId { get; set; }
        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AverageRating { get; set; }
        public int NumberOfRatings { get; set; }
    }
}

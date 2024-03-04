using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKBeauty.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public float CustomerRating { get; set; }
    }
}

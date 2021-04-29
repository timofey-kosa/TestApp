using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Order
    {
        public List<ProductForCart> Products { get; set; } = new List<ProductForCart>();
    }
}

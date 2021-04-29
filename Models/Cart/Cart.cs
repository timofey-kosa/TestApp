using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.Cart
{
    public static class Cart
    {
        public static List<ProductForCart> CartList { get; set; } = new List<ProductForCart>();
    }
}

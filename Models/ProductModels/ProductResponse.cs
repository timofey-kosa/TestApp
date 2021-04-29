using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.ProductModels
{
    public class ProductResponse
    {
        public IEnumerable<Product> Products { get; set; }
    }
}

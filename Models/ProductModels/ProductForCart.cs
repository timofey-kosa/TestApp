using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class ProductForCart
    {
        public int ProductId { get; set; }
        public int Qauntity { get; set; }
        public string Value { get; set; }
        public string BrandName { get; set; }
        public string Currency { get; set; }
        public string Denomination { get; set; }
    }
}

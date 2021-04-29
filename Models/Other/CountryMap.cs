using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class CountryMap
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public string SupplierCountryCode { get; set; }
        public int SupplierId { get; set; }
    }
}

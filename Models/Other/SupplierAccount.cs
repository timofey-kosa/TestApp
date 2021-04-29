using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class SupplierAccount
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public string AccountCode { get; set; }
        public decimal Balance { get; set; }
        public Currency Currency { get; set; }
    }
}

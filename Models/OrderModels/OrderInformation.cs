using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.OrderModels
{
    public class OrderInformation
    {
        public DateTime Date { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public decimal Price { get; set; }
        public decimal TotalValue { get; set; }
    }
}

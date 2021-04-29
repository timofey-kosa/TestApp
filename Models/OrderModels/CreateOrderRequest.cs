using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models.OrderModels;

namespace TestApp.Models
{
    public class CreateOrderRequest
    {
        public Guid RequestId { get; set; }
        public int AccountId { get; set; }
        public IEnumerable<OrderProduct> Products { get; set; }
    }
}

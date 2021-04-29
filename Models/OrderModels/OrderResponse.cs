using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class OrderResponse
    {
        public int OrderId { get; set; }
        public Guid RequestId { get; set; }
        public List<OrderItemResponse> Items { get; set; } = new List<OrderItemResponse>();
        public string Status { get;  set; }
        public DateTime CreatedDate { get; set; }
        public decimal Total { get; set; }
        public List<OrderFailureResponse> Failures { get; set; } = new List<OrderFailureResponse>();
    }
}

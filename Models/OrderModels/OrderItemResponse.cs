using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class OrderItemResponse
    {
        public string BrandCode { get; set; }
        public int ProductId { get; set; }
        public decimal ProductFaceValue { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public List<OrderCardResponse> Cards { get;  set; } = new List<OrderCardResponse>();
        public List<OrderFailureResponse> Failures { get;  set; } = new List<OrderFailureResponse>();
    }
}

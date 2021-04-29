using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class OrderCardResponse
    {
        public string SerialNumber { get; set; }
        public string CardCode { get; set; }
        public string Url { get; set; }
        public string Pin { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}

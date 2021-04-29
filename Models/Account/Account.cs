using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Account
    {

        public int Id { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
    }
}

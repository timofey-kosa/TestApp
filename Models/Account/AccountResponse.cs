using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class AccountResponse
    {
        public IEnumerable<Account> Accounts { get; set; }
    }
}

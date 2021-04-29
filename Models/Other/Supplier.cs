using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsIntegrated { get; set; }
        public IEnumerable<SupplierAccount> SupplierAccounts { get; set; }
        public IEnumerable<CountryMap> CountryAssignments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class ClientInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }
        public string AccountType { get; set; }
        public string IntegrationType { get; set; }
        public string Status { get; set; }
     //   public Catalog Catalog { get; set; }
    }
}

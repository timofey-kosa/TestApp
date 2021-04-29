using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string AccountType { get; set; }
        public string SettlementMethod { get; set; }
        public string CommercialStructure { get; set; }
       // public List<Contact> Contacts { get; set; }
        public string Status { get; set; }
        public string IntegrationType { get; set; }
        public string ContractUrl { get; set; }
      //  public List<Account> Accounts { get; set; }
        //public Catalog Catalog { get; set; }
    }
}

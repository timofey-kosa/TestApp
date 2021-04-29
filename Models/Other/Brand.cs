using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models.ProductModels;

namespace TestApp.Models
{
    public class Brand
    {   //[JsonProperty("id")]
        public int Id { get; set; }
        public string Code { get; set; } 
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public Supplier Supplier { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public string Description { get; set; }
        public string Disclamer { get; set; }
        public string RedemptionInstructions { get; set; }
        public string Terms { get; set; }
        public string LogoUrl { get; set; }
        public string CardPictureUrl { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

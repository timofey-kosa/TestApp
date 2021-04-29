using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class ProductForView
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string SupplierSku { get; set; }
        public string Name { get; set; }
        public decimal MinFaceValue { get; set; }
        public decimal MaxFaceValue { get; set; }
        public string SupplierDiscountType { get; set; }
        public decimal SupplierDiscountValue { get; set; }
        public decimal SupplierTransactionFee { get; set; }
       public Brand Brand { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}

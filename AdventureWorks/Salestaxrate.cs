using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salestaxrate
    {
        public int SalesTaxRateId { get; set; }
        public int StateProvinceId { get; set; }
        public sbyte TaxType { get; set; }
        public double TaxRate { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = null!;
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Vendoraddress
    {
        public int VendorId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Vendor
    {
        public int VendorId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public sbyte CreditRating { get; set; }
        public ulong PreferredVendorStatus { get; set; }
        public ulong ActiveFlag { get; set; }
        public string? PurchasingWebServiceUrl { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

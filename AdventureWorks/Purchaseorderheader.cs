using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Purchaseorderheader
    {
        public int? PurchaseOrderId { get; set; }
        public sbyte? RevisionNumber { get; set; }
        public sbyte? Status { get; set; }
        public int? EmployeeId { get; set; }
        public int? VendorId { get; set; }
        public int? ShipMethodId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public double? SubTotal { get; set; }
        public double? TaxAmt { get; set; }
        public double? Freight { get; set; }
        public double? TotalDue { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

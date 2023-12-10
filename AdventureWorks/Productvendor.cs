using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productvendor
    {
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public int AverageLeadTime { get; set; }
        public double StandardPrice { get; set; }
        public double? LastReceiptCost { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public int? MinOrderQty { get; set; }
        public int MaxOrderQty { get; set; }
        public int? OnOrderQty { get; set; }
        public string UnitMeasureCode { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

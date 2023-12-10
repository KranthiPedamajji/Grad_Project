using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salesperson
    {
        public int SalesPersonId { get; set; }
        public int? TerritoryId { get; set; }
        public double? SalesQuota { get; set; }
        public double Bonus { get; set; }
        public double CommissionPct { get; set; }
        public double SalesYtd { get; set; }
        public double SalesLastYear { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

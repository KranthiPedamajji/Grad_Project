using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salespersonquotahistory
    {
        public int SalesPersonId { get; set; }
        public DateTime QuotaDate { get; set; }
        public double SalesQuota { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

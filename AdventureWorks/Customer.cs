using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public int? TerritoryId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string CustomerType { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

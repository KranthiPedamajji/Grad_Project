using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Store
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public int? SalesPersonId { get; set; }
        public string? Demographics { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

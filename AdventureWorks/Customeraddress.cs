using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Customeraddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

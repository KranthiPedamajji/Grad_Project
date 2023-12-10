using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Addresstype
    {
        public int AddressTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

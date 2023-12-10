using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productinventory
    {
        public int ProductId { get; set; }
        public short LocationId { get; set; }
        public string Shelf { get; set; } = null!;
        public sbyte Bin { get; set; }
        public short Quantity { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

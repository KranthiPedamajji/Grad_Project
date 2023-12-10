using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Shipmethod
    {
        public int ShipMethodId { get; set; }
        public string Name { get; set; } = null!;
        public double ShipBase { get; set; }
        public double ShipRate { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

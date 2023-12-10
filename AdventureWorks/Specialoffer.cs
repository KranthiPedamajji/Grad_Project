using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Specialoffer
    {
        public int SpecialOfferId { get; set; }
        public string Description { get; set; } = null!;
        public double DiscountPct { get; set; }
        public string Type { get; set; } = null!;
        public string Category { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinQty { get; set; }
        public int? MaxQty { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

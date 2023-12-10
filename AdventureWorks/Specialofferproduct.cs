using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Specialofferproduct
    {
        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

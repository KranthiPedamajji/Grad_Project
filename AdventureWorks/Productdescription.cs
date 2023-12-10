using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productdescription
    {
        public int ProductDescriptionId { get; set; }
        public string Description { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

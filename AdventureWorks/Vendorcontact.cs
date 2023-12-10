using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Vendorcontact
    {
        public int VendorId { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

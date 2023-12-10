using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Storecontact
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

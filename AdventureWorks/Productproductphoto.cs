using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productproductphoto
    {
        public int ProductId { get; set; }
        public int ProductPhotoId { get; set; }
        public ulong Primary { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

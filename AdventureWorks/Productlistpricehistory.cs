using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productlistpricehistory
    {
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double ListPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

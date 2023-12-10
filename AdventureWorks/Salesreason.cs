using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salesreason
    {
        public int SalesReasonId { get; set; }
        public string Name { get; set; } = null!;
        public string ReasonType { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

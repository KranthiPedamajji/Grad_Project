using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Workorder
    {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderQty { get; set; }
        public int StockedQty { get; set; }
        public short ScrappedQty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime DueDate { get; set; }
        public short? ScrapReasonId { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

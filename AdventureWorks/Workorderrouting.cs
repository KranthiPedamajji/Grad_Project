using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Workorderrouting
    {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public short OperationSequence { get; set; }
        public short LocationId { get; set; }
        public DateTime ScheduledStartDate { get; set; }
        public DateTime ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? ActualResourceHrs { get; set; }
        public double PlannedCost { get; set; }
        public double? ActualCost { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

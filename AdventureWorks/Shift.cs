using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Shift
    {
        public int ShiftId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

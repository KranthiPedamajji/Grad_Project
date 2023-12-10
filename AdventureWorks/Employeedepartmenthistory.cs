using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Employeedepartmenthistory
    {
        public int EmployeeId { get; set; }
        public short DepartmentId { get; set; }
        public sbyte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

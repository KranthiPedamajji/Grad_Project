using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Employeepayhistory
    {
        public int EmployeeId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public double Rate { get; set; }
        public sbyte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

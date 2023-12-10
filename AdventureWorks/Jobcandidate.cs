using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Jobcandidate
    {
        public int JobCandidateId { get; set; }
        public int? EmployeeId { get; set; }
        public string? Resume { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

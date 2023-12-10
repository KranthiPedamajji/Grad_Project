using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

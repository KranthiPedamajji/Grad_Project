using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Employeeaddress
    {
        public int EmployeeId { get; set; }
        public int AddressId { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

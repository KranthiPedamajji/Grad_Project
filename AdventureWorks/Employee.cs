using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string NationalIdnumber { get; set; } = null!;
        public int ContactId { get; set; }
        public string LoginId { get; set; } = null!;
        public int? ManagerId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public ulong SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public ulong CurrentFlag { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

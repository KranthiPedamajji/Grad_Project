﻿using System;
using System.Collections.Generic;

namespace Grad_Project.NorthWindModels
{
    public partial class Privilege
    {
        public Privilege()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string? PrivilegeName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

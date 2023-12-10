﻿using System;
using System.Collections.Generic;

namespace Grad_Project.Sakila
{
    public partial class StaffList
    {
        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? ZipCode { get; set; }
        public string Phone { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public byte Sid { get; set; }
    }
}

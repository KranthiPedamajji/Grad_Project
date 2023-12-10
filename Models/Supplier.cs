using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Supplier
    {
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
    }
}

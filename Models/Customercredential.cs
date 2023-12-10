using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Customercredential
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
    }
}

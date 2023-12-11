using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Orderdetail
    {
        public int OrderDetailId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Quantity { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = null!;
    }
}

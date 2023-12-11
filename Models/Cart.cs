using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? CustomerId { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}

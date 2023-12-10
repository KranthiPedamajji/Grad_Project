using System;
using System.Collections.Generic;

#nullable disable

namespace Grad_Project.Models
{
    public partial class Restocking
    {
        public int RestockingId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? StatusId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Restockingstatus Status { get; set; }
    }
}

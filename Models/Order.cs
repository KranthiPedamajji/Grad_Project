using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? StatusId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Orderstatus? Status { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}

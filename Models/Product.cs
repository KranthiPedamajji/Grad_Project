using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Product
    {
        public Product()
        {
            Ratings = new HashSet<Rating>();
            Restockings = new HashSet<Restocking>();
        }

        public int ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? ListPrice { get; set; }
        public int? InStock { get; set; }
        public int? TargetLevel { get; set; }
        public string? QuantityPerUnit { get; set; }
        public bool? Discontinued { get; set; }
        public int? MinimumInstockQuantity { get; set; }
        public string? Category { get; set; }
        public byte[]? Attachments { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Restocking> Restockings { get; set; }
    }
}

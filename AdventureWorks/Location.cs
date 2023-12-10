using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; } = null!;
        public double CostRate { get; set; }
        public decimal Availability { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

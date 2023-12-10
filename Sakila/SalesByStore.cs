using System;
using System.Collections.Generic;

namespace Grad_Project.Sakila
{
    public partial class SalesByStore
    {
        public string Store { get; set; } = null!;
        public string Manager { get; set; } = null!;
        public decimal? TotalSales { get; set; }
    }
}

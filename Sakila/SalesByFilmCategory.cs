using System;
using System.Collections.Generic;

namespace Grad_Project.Sakila
{
    public partial class SalesByFilmCategory
    {
        public string Category { get; set; } = null!;
        public decimal? TotalSales { get; set; }
    }
}

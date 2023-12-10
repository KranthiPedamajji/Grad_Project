using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Currency
    {
        public string CurrencyCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Countryregioncurrency
    {
        public string CountryRegionCode { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

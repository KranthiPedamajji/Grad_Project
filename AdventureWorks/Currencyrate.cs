using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Currencyrate
    {
        public int CurrencyRateId { get; set; }
        public DateTime CurrencyRateDate { get; set; }
        public string FromCurrencyCode { get; set; } = null!;
        public string ToCurrencyCode { get; set; } = null!;
        public double AverageRate { get; set; }
        public double EndOfDayRate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

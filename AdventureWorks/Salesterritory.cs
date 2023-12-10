using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salesterritory
    {
        public int TerritoryId { get; set; }
        public string Name { get; set; } = null!;
        public string CountryRegionCode { get; set; } = null!;
        public string Group { get; set; } = null!;
        public double SalesYtd { get; set; }
        public double SalesLastYear { get; set; }
        public double CostYtd { get; set; }
        public double CostLastYear { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

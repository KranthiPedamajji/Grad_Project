using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Stateprovince
    {
        public int StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; } = null!;
        public string CountryRegionCode { get; set; } = null!;
        public ulong IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; } = null!;
        public int TerritoryId { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

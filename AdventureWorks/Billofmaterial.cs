using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Billofmaterial
    {
        public int BillOfMaterialsId { get; set; }
        public int? ProductAssemblyId { get; set; }
        public int ComponentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UnitMeasureCode { get; set; } = null!;
        public short Bomlevel { get; set; }
        public decimal PerAssemblyQty { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

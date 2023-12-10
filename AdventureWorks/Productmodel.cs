using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productmodel
    {
        public int ProductModelId { get; set; }
        public string Name { get; set; } = null!;
        public string? CatalogDescription { get; set; }
        public string? Instructions { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

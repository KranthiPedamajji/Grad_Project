using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productmodelproductdescriptionculture
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string CultureId { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

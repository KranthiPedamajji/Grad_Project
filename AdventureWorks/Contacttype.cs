using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Contacttype
    {
        public int ContactTypeId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

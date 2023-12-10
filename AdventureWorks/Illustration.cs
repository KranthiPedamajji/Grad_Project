using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Illustration
    {
        public int IllustrationId { get; set; }
        public string? Diagram { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

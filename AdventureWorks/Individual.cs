using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Individual
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public string? Demographics { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

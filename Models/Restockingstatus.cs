using System;
using System.Collections.Generic;

#nullable disable

namespace Grad_Project.Models
{
    public partial class Restockingstatus
    {
        public Restockingstatus()
        {
            Restockings = new HashSet<Restocking>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Restocking> Restockings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; } = null!;
        public string? Description { get; set; }
    }
}

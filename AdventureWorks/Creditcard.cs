using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Creditcard
    {
        public int CreditCardId { get; set; }
        public string CardType { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public sbyte ExpMonth { get; set; }
        public short ExpYear { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

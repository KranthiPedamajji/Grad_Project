using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Transactionhistoryarchive
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = null!;
        public int Quantity { get; set; }
        public double ActualCost { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

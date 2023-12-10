using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Salesorderheader
    {
        public int SalesOrderId { get; set; }
        public sbyte RevisionNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ShipDate { get; set; }
        public sbyte Status { get; set; }
        public ulong OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; } = null!;
        public string? PurchaseOrderNumber { get; set; }
        public string? AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? TerritoryId { get; set; }
        public int BillToAddressId { get; set; }
        public int ShipToAddressId { get; set; }
        public int ShipMethodId { get; set; }
        public int? CreditCardId { get; set; }
        public string? CreditCardApprovalCode { get; set; }
        public int? CurrencyRateId { get; set; }
        public double SubTotal { get; set; }
        public double TaxAmt { get; set; }
        public double Freight { get; set; }
        public double TotalDue { get; set; }
        public string? Comment { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

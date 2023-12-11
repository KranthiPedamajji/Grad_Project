namespace Grad_Project.Models
{
    public class OrdersModel
    {

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ProductName { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? StatusId { get; set; }
        public List<string> PartnerName { get; set; }
        public List<int> ProductIds { get; set; }
        public List<int> Quantities { get; set; }
    }
}

namespace Grad_Project.Models
{
    public class OrdersModel
    {
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
        public List<int> Quantities { get; set; }
    }
}

namespace Grad_Project.Models
{
    public class CustomerModel
    {
        // Properties for customer data
        // Add properties based on your actual Customers table structure
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? JobTitle { get; set; }
        public string? BusinessPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? StateProvince { get; set; }
        public string? ZipPostalCode { get; set; }
        public string? CountryRegion { get; set; }
        public string? WebPage { get; set; }
        public string? Notes { get; set; }
        public byte[]? Attachments { get; set; }
        public string CustomerName { get; set; }
        public string PasswordHash { get; set; }
    }
}

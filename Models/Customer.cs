using System;
using System.Collections.Generic;

#nullable disable

namespace Grad_Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        public byte[] Attachments { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }


//public static class CustomerEndpoints
//{
//	public static void MapCustomerEndpoints (this IEndpointRouteBuilder routes)
//    {
//        routes.MapGet("/api/Customer", () =>
//        {
//            return new [] { new Customer() };
//        })
//        .WithName("GetAllCustomers")
//        .Produces<Customer[]>(StatusCodes.Status200OK);

//        routes.MapGet("/api/Customer/{id}", (int id) =>
//        {
//            //return new Customer { ID = id };
//        })
//        .WithName("GetCustomerById")
//        .Produces<Customer>(StatusCodes.Status200OK);

//        routes.MapPut("/api/Customer/{id}", (int id, Customer input) =>
//        {
//            return Results.NoContent();
//        })
//        .WithName("UpdateCustomer")
//        .Produces(StatusCodes.Status204NoContent);

//        routes.MapPost("/api/Customer/", (Customer model) =>
//        {
//            //return Results.Created($"//api/Customers/{model.ID}", model);
//        })
//        .WithName("CreateCustomer")
//        .Produces<Customer>(StatusCodes.Status201Created);

//        routes.MapDelete("/api/Customer/{id}", (int id) =>
//        {
//            //return Results.Ok(new Customer { ID = id });
//        })
//        .WithName("DeleteCustomer")
//        .Produces<Customer>(StatusCodes.Status200OK);
//    }
//}
}

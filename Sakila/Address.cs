using System;
using System.Collections.Generic;
using MySql.Data.Types;

namespace Grad_Project.Sakila
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Staff = new HashSet<Staff>();
            Stores = new HashSet<Store>();
        }

        public ushort AddressId { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string District { get; set; } = null!;
        public ushort CityId { get; set; }
        public string? PostalCode { get; set; }
        public string Phone { get; set; } = null!;
        public MySqlGeometry Location { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

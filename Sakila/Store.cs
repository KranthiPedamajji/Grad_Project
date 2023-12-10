using System;
using System.Collections.Generic;

namespace Grad_Project.Sakila
{
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();
            Inventories = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        public byte StoreId { get; set; }
        public byte ManagerStaffId { get; set; }
        public ushort AddressId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Staff ManagerStaff { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}

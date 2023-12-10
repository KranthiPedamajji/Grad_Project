using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Shoppingcartitem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; } = null!;
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

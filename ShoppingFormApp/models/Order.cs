using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormApp.models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        public virtual ProductId Product { get; set; }
        public virtual User User { get; set; }
    }
}

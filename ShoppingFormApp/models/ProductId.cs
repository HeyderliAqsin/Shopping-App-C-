using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormApp.models
{
    public partial class ProductId
    {
        public ProductId()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId1 { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

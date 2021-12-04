using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormApp.models
{
    public partial class Category
    {
        public Category()
        {
            ProductIds = new HashSet<ProductId>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductId> ProductIds { get; set; }
    }
}

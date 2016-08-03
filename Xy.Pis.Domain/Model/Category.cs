
using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class Category : EntityBase
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

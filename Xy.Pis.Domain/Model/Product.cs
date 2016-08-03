
using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class Product : EntityBase
    {
        public Product()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

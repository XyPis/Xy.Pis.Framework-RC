
using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class Customer : EntityBase
    {
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}


using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class OrderDetail : EntityBase
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemNo { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmt { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

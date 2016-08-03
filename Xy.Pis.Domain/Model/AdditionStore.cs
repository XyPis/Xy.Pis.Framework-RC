using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class AdditionStore
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal RetailPrice { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public string Memo { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
    }
}

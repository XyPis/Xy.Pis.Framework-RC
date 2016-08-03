using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class RmStockReqdtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual RmStockReq RmStockReq { get; set; }
    }
}

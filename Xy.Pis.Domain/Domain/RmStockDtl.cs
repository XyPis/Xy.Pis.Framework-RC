using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class RmStockDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public string InBatchNo { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal StockPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> LimitDate { get; set; }
        public bool IsBid { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<int> ManuId { get; set; }
        public string PassNo { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsManufacturer BsManufacturer { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual RmStock RmStock { get; set; }
    }
}

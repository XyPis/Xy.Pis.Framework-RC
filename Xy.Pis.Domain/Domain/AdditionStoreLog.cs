using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class AdditionStoreLog
    {
        public int ID { get; set; }
        public System.DateTime HappenTime { get; set; }
        public int LocationId { get; set; }
        public int ItemId { get; set; }
        public decimal BeforeStockNum { get; set; }
        public decimal HappenNum { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public int UnitId { get; set; }
        public short LsActType { get; set; }
        public string Memo { get; set; }
        public decimal AfterStockNum { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
    }
}

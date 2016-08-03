using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class AdditionFee
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal PriceIn { get; set; }
        public decimal AmountPay { get; set; }
        public bool IsCancel { get; set; }
        public int FeeType { get; set; }
        public string Memo { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
    }
}

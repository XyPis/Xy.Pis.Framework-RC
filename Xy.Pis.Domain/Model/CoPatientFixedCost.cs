using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoPatientFixedCost
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> LsItemType { get; set; }
        public short LsMonthlyCharged { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscIn { get; set; }
        public decimal AddRatio { get; set; }
        public decimal AmountPay { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> LastChargeOperId { get; set; }
        public Nullable<System.DateTime> LastChargeOperTime { get; set; }
        public bool IsStopCharge { get; set; }
        public Nullable<int> StopChargeOperID { get; set; }
        public Nullable<System.DateTime> StopChargeOperTime { get; set; }
        public Nullable<System.DateTime> StopChargeTime { get; set; }
        public Nullable<System.DateTime> LastChangeItemTime { get; set; }
        public string Memo { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}

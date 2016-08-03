using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoPatientPrimeCost
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public Nullable<int> HosRenewId { get; set; }
        public int LsPrimeType { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscIn { get; set; }
        public decimal AddRatio { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<decimal> AmountBack { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public bool IsCharge { get; set; }
        public Nullable<int> ChargeOperId { get; set; }
        public Nullable<System.DateTime> ChargeOperTime { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<int> CancelId { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public string Memo { get; set; }
        public Nullable<int> CoPatientPrimeCostMainID { get; set; }
        public Nullable<int> InvoId { get; set; }
        public Nullable<short> LsSource { get; set; }
        public Nullable<int> SourceId { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InHosInfoRenew InHosInfoRenew { get; set; }
    }
}

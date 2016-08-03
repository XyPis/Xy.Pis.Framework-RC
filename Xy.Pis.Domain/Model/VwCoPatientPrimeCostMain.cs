using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwCoPatientPrimeCostMain
    {
        public int ID { get; set; }
        public string InvoNo { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public string IdCardNo { get; set; }
        public int NTime { get; set; }
        public int HospId { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public string CancelMemo { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> CheckOperID { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
    }
}

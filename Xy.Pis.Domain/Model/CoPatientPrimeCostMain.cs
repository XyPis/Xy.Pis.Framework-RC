using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoPatientPrimeCostMain
    {
        public int ID { get; set; }
        public string InvoNo { get; set; }
        public int HospId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> Complement { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public string CancelMemo { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> CheckOperID { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public string DepositBillNo { get; set; }
    }
}

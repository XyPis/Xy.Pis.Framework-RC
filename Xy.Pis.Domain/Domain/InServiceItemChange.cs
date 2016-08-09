using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InServiceItemChange
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int LsChangeType { get; set; }
        public Nullable<int> ChangeId { get; set; }
        public int ChangeItemId { get; set; }
        public Nullable<decimal> ChangeAmount { get; set; }
        public string ChangeName { get; set; }
        public string ChangeReason { get; set; }
        public bool IsSubmit { get; set; }
        public string ReturnReason { get; set; }
        public bool DelFlag { get; set; }
        public Nullable<int> ApplyId { get; set; }
        public string ApplyName { get; set; }
        public Nullable<int> ApplyItemId { get; set; }
        public Nullable<decimal> ApplyAmount { get; set; }
        public Nullable<int> ApplyOperId { get; set; }
        public Nullable<System.DateTime> ApplyTime { get; set; }
        public Nullable<int> LsAuditStatus { get; set; }
        public Nullable<int> AuditOperId { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public Nullable<System.DateTime> BeginExecuteTime { get; set; }
        public Nullable<bool> IsExecute { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<bool> IsSubmitFee { get; set; }
        public string CoPatientPrimeCostId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoDiscountApply
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public byte LsDiscountType { get; set; }
        public byte DiscountRatio { get; set; }
        public string DiscountReason { get; set; }
        public int IsSubmit { get; set; }
        public string ReturnReason { get; set; }
        public bool DelFlag { get; set; }
        public Nullable<int> ApplyID { get; set; }
        public Nullable<System.DateTime> ApplyTime { get; set; }
        public Nullable<byte> LsAuditStatus { get; set; }
        public Nullable<int> AuditId { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public Nullable<System.DateTime> BeginExecuteTime { get; set; }
        public string Remark { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}

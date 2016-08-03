using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoRetreatLive
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public string CheckInPlace { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<System.DateTime> ExecuteTime { get; set; }
        public Nullable<int> LsLive { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> AuditOperId { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
    }
}

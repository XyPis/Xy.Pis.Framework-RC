using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InOutNote
    {
        public int ID { get; set; }
        public int HospID { get; set; }
        public string CheckInPlace { get; set; }
        public Nullable<System.DateTime> LeaveTime { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public string LeaveReason { get; set; }
        public string Memo { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
    }
}

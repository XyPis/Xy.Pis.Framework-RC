using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InStopMeal
    {
        public int ID { get; set; }
        public int HospID { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CheckInArea { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> AuditOperID { get; set; }
        public Nullable<System.DateTime> AuditOperTime { get; set; }
    }
}

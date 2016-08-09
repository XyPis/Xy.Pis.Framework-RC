using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InStopMealRegister : EntityBase
    {
        public int ID { get; set; }
        public int LocationID { get; set; }
        public Nullable<int> OrderMealsCount { get; set; }
        public Nullable<int> StopMealCount { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> AuditID { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
    }
}

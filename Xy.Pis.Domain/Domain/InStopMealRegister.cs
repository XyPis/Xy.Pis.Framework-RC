using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InStopMealRegister : EntityBase
    {
        public int ID { get; set; }
        
        public int LocationID { get; set; }
        
        public int? OrderMealsCount { get; set; }
        
        public int? StopMealCount { get; set; }
        
        public int OperID { get; set; }
        
        public System.DateTime OperTime { get; set; }
        
        public bool? IsAudit { get; set; }
        
        public int? AuditID { get; set; }
        
        public DateTime? AuditTime { get; set; }
    }
}

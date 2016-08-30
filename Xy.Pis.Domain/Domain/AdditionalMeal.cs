using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Domain
{
    public partial class AdditionalMeal : EntityBase
    {
        public AdditionalMeal()
        {
            this.Details = new List<AdditionalMealDetails>();
        }

        public int Id { get; set; }

        public int HospId { get; set; }
        
        public System.DateTime OrderDate { get; set; }
        
        public int LocationId { get; set; }

        public int OrderStatus { get; set; }

        public int? Auditor { get; set; }
        
        public DateTime? AuditDate { get; set; }
        
        public int? Canceller { get; set; }
        
        public DateTime? CancellationDate { get; set; }
        
        public int AddUser { get; set; }
        
        public System.DateTime AddDate { get; set; }
        
        public int UpdtUser { get; set; }
        
        public System.DateTime UpdtDate { get; set; }
        
        public virtual InHosInfo InHosInfo { get; set; }
        
        public virtual ICollection<AdditionalMealDetails> Details { get; set; }
    }
}

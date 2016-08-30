using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmWorkRepair : EntityBase
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Position { get; set; }
        
        public int? LocationId { get; set; }
        
        public int? RepairLocationId { get; set; }
        
        public DateTime? CompletionBeginTime { get; set; }
        
        public DateTime? CompletionEndTime { get; set; }
        
        public string Memo { get; set; }
        
        public int? LsStatus { get; set; }
        
        public int? OperId { get; set; }
        
        public DateTime? OperTime { get; set; }
        
        public virtual BsLocation ReponsiblityLoc { get; set; }        
    }
}

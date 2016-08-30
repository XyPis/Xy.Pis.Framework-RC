using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public class EngineeringMaintenanceDTO : DTOBase
    {       
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Position { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? RepairLocationId { get; set; }

        [DataMember]
        public DateTime? CompletionBeginTime { get; set; }

        [DataMember]
        public DateTime? CompletionEndTime { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? LsStatus { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public DateTime? OperTime { get; set; }
    }
}

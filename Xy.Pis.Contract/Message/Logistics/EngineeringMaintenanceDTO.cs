using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

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
        public Nullable<int> LocationId { get; set; }

        [DataMember]
        public Nullable<int> RepairLocationId { get; set; }

        [DataMember]
        public Nullable<System.DateTime> CompletionBeginTime { get; set; }

        [DataMember]
        public Nullable<System.DateTime> CompletionEndTime { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public Nullable<int> LsStatus { get; set; }

        [DataMember]
        public Nullable<int> OperId { get; set; }

        [DataMember]
        public Nullable<System.DateTime> OperTime { get; set; }
    }
}

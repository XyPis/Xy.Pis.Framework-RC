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
        public int ID { get; set; }

        [DataMember]
        public string FacilityName { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public Nullable<int> LocationId { get; set; }

        [DataMember]
        public Nullable<int> ResponsiblityLocId { get; set; }

        [DataMember]
        public Nullable<System.DateTime> ETC { get; set; }

        [DataMember]
        public Nullable<System.DateTime> ATC { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public Nullable<int> Status { get; set; }

        [DataMember]
        public Nullable<int> OperId { get; set; }

        [DataMember]
        public Nullable<System.DateTime> OperTime { get; set; }
    }
}

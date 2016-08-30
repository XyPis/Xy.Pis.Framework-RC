using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public class StopMealRegisterationDTO : DTOBase
    {
        [DataMember]
        public int LocationID { get; set; }

        [DataMember]
        public int? OrderQty { get; set; }

        [DataMember]
        public int? CancelQty { get; set; }

        [DataMember]
        public int OperID { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public bool? IsAudit { get; set; }

        [DataMember]
        public int? AuditID { get; set; }

        [DataMember]
        public DateTime? AuditTime { get; set; }    
    }
}

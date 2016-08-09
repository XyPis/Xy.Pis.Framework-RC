using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public class StopMealRegisterationDTO : DTOBase
    {
        [DataMember]
        public int LocationID { get; set; }

        [DataMember]
        public Nullable<int> OrderQty { get; set; }

        [DataMember]
        public Nullable<int> CancelQty { get; set; }

        [DataMember]
        public int OperID { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public Nullable<bool> IsAudit { get; set; }

        [DataMember]
        public Nullable<int> AuditID { get; set; }

        [DataMember]
        public Nullable<System.DateTime> AuditTime { get; set; }    
    }
}

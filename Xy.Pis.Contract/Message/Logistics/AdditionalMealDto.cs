using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class AdditionalMealDTO : DTOBase
    {
        public AdditionalMealDTO()
        {
            this.Details = new List<AdditionalMealDetailsDTO>();
        }

        [DataMember]
        public int HospId { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LocFullName { get; set; }

        [DataMember]
        public System.DateTime OrderDate { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int OrderStatus { get; set; }

        [DataMember]
        public int? Auditor { get; set; }

        [DataMember]
        public DateTime? AuditDate { get; set; }

        [DataMember]
        public int? Canceller { get; set; }

        [DataMember]
        public DateTime? CancellationDate { get; set; }

        [DataMember]
        public int AddUser { get; set; }

        [DataMember]
        public System.DateTime AddDate { get; set; }

        [DataMember]
        public int UpdtUser { get; set; }

        [DataMember]
        public System.DateTime UpdtDate { get; set; }

        [DataMember]
        public virtual ICollection<AdditionalMealDetailsDTO> Details { get; set; }

        // [DataMember]
        // public virtual LocationDto Location { get; set; }

        // [DataMember]
        // public virtual UserDto User { get; set; }

        // [DataMember]
        // public virtual InHosInfoDto InHosInfo { get; set; }
    }
}

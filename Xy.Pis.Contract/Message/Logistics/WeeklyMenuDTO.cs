using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class WeeklyMenuDTO : DTOBase
    {
        public WeeklyMenuDTO()
        {
        }

        [DataMember]
        public string LsData { get; set; }

        [DataMember]
        public int? CreatorId { get; set; }

        [DataMember]
        public System.DateTime CreateTime { get; set; }

        [DataMember]
        public System.DateTime LastModifyTime { get; set; }

        [DataMember]
        public int? LastModify { get; set; }

        [DataMember]
        public System.DateTime StartDate { get; set; }

        [DataMember]
        public System.DateTime EndDate { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }
    }
}

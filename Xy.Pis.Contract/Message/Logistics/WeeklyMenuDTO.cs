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
            //this.DailyMenus = new List<DailyMenuDto>();
        }

        [DataMember]
        public string lsData { get; set; }

        [DataMember]
        public Nullable<int> CreatorId { get; set; }

        [DataMember]
        public System.DateTime CreateTime { get; set; }

        [DataMember]
        public System.DateTime LastModifyTime { get; set; }

        [DataMember]
        public Nullable<int> LastModify { get; set; }

        [DataMember]
        public System.DateTime StartDate { get; set; }

        [DataMember]
        public System.DateTime EndDate { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        //[DataMember]
        //public virtual ICollection<DailyMenuDto> DailyMenus { get; set; }
    }
}

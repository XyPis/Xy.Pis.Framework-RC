using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHosEntrustService
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> EntrustItemId { get; set; }
        public Nullable<int> HosRenewId { get; set; }
        public virtual BsEntrustItem BsEntrustItem { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InHosInfoRenew InHosInfoRenew { get; set; }
    }
}

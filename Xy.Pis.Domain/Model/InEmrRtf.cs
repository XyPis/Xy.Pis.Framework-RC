using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InEmrRtf
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public int CatalogId { get; set; }
        public string Rtf { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}

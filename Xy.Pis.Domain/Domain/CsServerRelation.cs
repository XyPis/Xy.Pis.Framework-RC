using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CsServerRelation
    {
        public int ID { get; set; }
        public int SeverLocId { get; set; }
        public int BenefitLocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
    }
}

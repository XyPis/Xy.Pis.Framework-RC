using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InInvoiceDtlBed
    {
        public int ID { get; set; }
        public int DetailId { get; set; }
        public int BedItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
    }
}

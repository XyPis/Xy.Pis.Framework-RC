using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InEmrSign
    {
        public int ID { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<int> EmrId { get; set; }
        public string SignValue { get; set; }
        public Nullable<System.DateTime> SignDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

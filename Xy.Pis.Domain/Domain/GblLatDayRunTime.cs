using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblLatDayRunTime
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> LastTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

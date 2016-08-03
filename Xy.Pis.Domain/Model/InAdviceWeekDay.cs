using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InAdviceWeekDay
    {
        public int ID { get; set; }
        public int AdviceId { get; set; }
        public short WeekDay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual InAdviceLong InAdviceLong { get; set; }
    }
}

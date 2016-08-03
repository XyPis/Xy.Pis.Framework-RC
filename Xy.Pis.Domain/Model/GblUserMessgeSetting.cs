using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblUserMessgeSetting
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int LsMessageType { get; set; }
        public int IntervalMinute { get; set; }
    }
}

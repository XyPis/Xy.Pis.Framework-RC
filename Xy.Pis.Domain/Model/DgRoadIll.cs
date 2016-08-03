using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class DgRoadIll
    {
        public int ID { get; set; }
        public Nullable<int> IllId { get; set; }
        public int RoadId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

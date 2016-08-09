using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblModiHost
    {
        public int ID { get; set; }
        public string BaseTable { get; set; }
        public string Hostname { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

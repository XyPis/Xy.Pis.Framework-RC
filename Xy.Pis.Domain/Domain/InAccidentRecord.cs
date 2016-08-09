using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InAccidentRecord
    {
        public int ID { get; set; }
        public int HospID { get; set; }
        public string HappenDate { get; set; }
        public string HappenTime { get; set; }
        public Nullable<int> DutyOperID { get; set; }
        public string Reason { get; set; }
        public string HandleResults { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
    }
}

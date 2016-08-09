using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InWatchBed
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<short> LsState { get; set; }
    }
}

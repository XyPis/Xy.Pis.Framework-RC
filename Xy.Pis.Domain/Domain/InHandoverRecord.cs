using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHandoverRecord
    {
        public int ID { get; set; }
        public int ShiftOperID { get; set; }
        public int SucceedID { get; set; }
        public int FloorNum { get; set; }
        public Nullable<System.DateTime> ShiftTime { get; set; }
        public Nullable<int> YardNum { get; set; }
        public Nullable<int> OutYardNum { get; set; }
        public Nullable<int> TurnOutNum { get; set; }
        public Nullable<int> TurnInNum { get; set; }
        public Nullable<int> HeavyNum { get; set; }
        public Nullable<int> DangerNum { get; set; }
        public Nullable<int> LeaveNum { get; set; }
        public Nullable<int> Totality { get; set; }
        public string HandoverRecord { get; set; }
        public Nullable<bool> IsConfirm { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
    }
}

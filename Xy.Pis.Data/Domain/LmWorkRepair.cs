using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmWorkRepair : EntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> RepairLocationId { get; set; }
        public Nullable<System.DateTime> CompletionBeginTime { get; set; }
        public Nullable<System.DateTime> CompletionEndTime { get; set; }
        public string Memo { get; set; }
        public Nullable<int> LsStatus { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InDrawMoney
    {
        public int ID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DrawOperId { get; set; }
        public Nullable<System.DateTime> DrawOperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Purpose { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Unit { get; set; }
        public string BackComment { get; set; }
        public Nullable<int> LsStatus { get; set; }
        public Nullable<int> ModifyOperId { get; set; }
        public Nullable<System.DateTime> ModifyOperTime { get; set; }
    }
}

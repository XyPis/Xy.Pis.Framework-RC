using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InRepayment
    {
        public int ID { get; set; }
        public Nullable<int> DrawMoneyId { get; set; }
        public Nullable<System.DateTime> RePayTime { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Remark { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> ModifyOperId { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
    }
}

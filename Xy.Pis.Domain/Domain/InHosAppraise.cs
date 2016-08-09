using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHosAppraise
    {
        public int ID { get; set; }
        public int BsAppraiseID { get; set; }
        public int HospId { get; set; }
        public Nullable<decimal> EvaluAllScore { get; set; }
        public Nullable<int> EvaluLevelID { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<System.DateTime> AppraiseTime { get; set; }
    }
}

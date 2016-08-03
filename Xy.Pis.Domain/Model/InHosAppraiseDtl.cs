using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHosAppraiseDtl
    {
        public int ID { get; set; }
        public int InHosAppraiseID { get; set; }
        public int OptionID { get; set; }
        public Nullable<decimal> AppraiseScores { get; set; }
        public string Memo { get; set; }
        public Nullable<int> QuestionID { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsAppraiseOption
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> BsAppraiseQuestionID { get; set; }
        public Nullable<decimal> OptionScores { get; set; }
        public Nullable<int> BsAppraiseTitleID { get; set; }
        public Nullable<bool> IsInput { get; set; }
    }
}

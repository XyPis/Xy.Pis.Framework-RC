using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsAppraiseQuestion
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> BsAppraiseTitleId { get; set; }
        public Nullable<short> LsQuestionType { get; set; }
        public Nullable<decimal> ItemMaxScore { get; set; }
    }
}

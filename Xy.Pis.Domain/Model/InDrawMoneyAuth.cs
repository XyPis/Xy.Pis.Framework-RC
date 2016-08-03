using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InDrawMoneyAuth
    {
        public int ID { get; set; }
        public Nullable<int> DrawMoneyId { get; set; }
        public string DrawStepName { get; set; }
        public Nullable<int> UserLevelId { get; set; }
        public Nullable<int> ApprovalOperId { get; set; }
        public Nullable<int> LsApprovalStatus { get; set; }
        public Nullable<System.DateTime> ApprovalTime { get; set; }
        public string ApprovalResult { get; set; }
        public string ApprovalComment { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OrderBy { get; set; }
    }
}

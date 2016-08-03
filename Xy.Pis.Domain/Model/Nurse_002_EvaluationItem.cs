using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class Nurse_002_EvaluationItem
    {
        public int ID { get; set; }
        public Nullable<int> CID { get; set; }
        public int EvaluationTypeID { get; set; }
        public Nullable<int> EvaluationItemID { get; set; }
        public string EvaluationItemName { get; set; }
        public double ItemMaxScore { get; set; }
        public Nullable<bool> DelFlag { get; set; }
        public string ModifiedID { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}

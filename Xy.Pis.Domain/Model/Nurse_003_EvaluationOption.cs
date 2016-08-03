using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class Nurse_003_EvaluationOption
    {
        public int ID { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<int> EvaluationItemID { get; set; }
        public string OptionContent { get; set; }
        public Nullable<double> OptionScore { get; set; }
        public string InputType { get; set; }
        public Nullable<bool> DelFlag { get; set; }
        public string ModifiedID { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}

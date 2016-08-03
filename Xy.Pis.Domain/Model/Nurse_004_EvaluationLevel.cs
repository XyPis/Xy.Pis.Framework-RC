using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class Nurse_004_EvaluationLevel
    {
        public int ID { get; set; }
        public Nullable<int> CID { get; set; }
        public string EvaluationType { get; set; }
        public int EvaluLevel { get; set; }
        public string LevelConditionName { get; set; }
        public Nullable<double> MinScore { get; set; }
        public Nullable<double> MaxScore { get; set; }
        public string ModifiedID { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}

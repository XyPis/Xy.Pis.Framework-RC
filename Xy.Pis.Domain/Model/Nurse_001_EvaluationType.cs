using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class Nurse_001_EvaluationType
    {
        public int ID { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<int> EvaluationTypeID { get; set; }
        public string EvaluationType { get; set; }
        public string EvaluationTypeName { get; set; }
        public Nullable<bool> DelFlag { get; set; }
        public string ModifiedID { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
    }
}

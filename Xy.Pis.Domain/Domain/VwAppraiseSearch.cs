using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwAppraiseSearch
    {
        public int ID { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public string CheckInPlace { get; set; }
        public Nullable<decimal> AppraiseScore { get; set; }
        public Nullable<int> AppraiseGrade { get; set; }
        public Nullable<System.DateTime> AppraiseTime { get; set; }
        public Nullable<int> OperID { get; set; }
        public int AppraiseType { get; set; }
        public int HospId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblReportDetail
    {
        public int ID { get; set; }
        public int GroupId { get; set; }
        public int FeeId { get; set; }
        public virtual GblReportGroup GblReportGroup { get; set; }
    }
}

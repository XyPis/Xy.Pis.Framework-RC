using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InLocNoPay
    {
        public int Id { get; set; }
        public System.DateTime ReportDate { get; set; }
        public int LocationId { get; set; }
        public int ExecLocId { get; set; }
        public int FeeId { get; set; }
        public short LsInStatus { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Opertime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InMonthFeeBill
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public int BedId { get; set; }
        public int BedFloorId { get; set; }
        public int FeeMonth { get; set; }
        public int FeeDays { get; set; }
        public int FeeId { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public bool IsPay { get; set; }
        public Nullable<int> PayId { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public bool IsAudit { get; set; }
        public Nullable<int> AuditId { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
    }
}

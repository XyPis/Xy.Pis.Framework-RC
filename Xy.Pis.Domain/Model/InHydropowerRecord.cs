using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHydropowerRecord
    {
        public InHydropowerRecord()
        {
            this.inHyDropowerDetails = new List<inHyDropowerDetail>();
        }

        public int ID { get; set; }
        public int YearMonth { get; set; }
        public int FloorNumId { get; set; }
        public string RoomBedNum { get; set; }
        public int HospId { get; set; }
        public int LastMonthElectricity { get; set; }
        public int CurrentMonthElectricity { get; set; }
        public decimal ElectricMothNumbers { get; set; }
        public int ContinuousLeaveDays { get; set; }
        public int MealDays { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Memo { get; set; }
        public Nullable<int> AuditID { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public virtual ICollection<inHyDropowerDetail> inHyDropowerDetails { get; set; }
    }
}

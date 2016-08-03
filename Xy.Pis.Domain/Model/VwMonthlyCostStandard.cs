using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwMonthlyCostStandard
    {
        public int ID { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string Name { get; set; }
        public decimal PriceIn { get; set; }
        public string ExpenseType { get; set; }
        public int BackDays { get; set; }
        public bool IsActive { get; set; }
        public string BedYearTypeName { get; set; }
        public int BedRoomTypeId { get; set; }
        public int BedYearTypeId { get; set; }
        public int BedFloorId { get; set; }
    }
}

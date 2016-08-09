using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoYearRoomFee
    {
        public int ID { get; set; }
        public int BedRoomTypeId { get; set; }
        public int BedYearTypeId { get; set; }
        public decimal PriceIn { get; set; }
        public bool IsActive { get; set; }
        public int BedFloorId { get; set; }
    }
}

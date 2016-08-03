using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHydropower
    {
        public int ID { get; set; }
        public string RoomNum { get; set; }
        public int FloorNum { get; set; }
        public string HappenTime { get; set; }
        public Nullable<decimal> LastTimeWaterFee { get; set; }
        public Nullable<decimal> LastTimeElectricFee { get; set; }
        public Nullable<decimal> WaterFee { get; set; }
        public Nullable<decimal> ElectricFee { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Memo { get; set; }
    }
}

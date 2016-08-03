using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHydropowerFee
    {
        public int ID { get; set; }
        public int HospID { get; set; }
        public int BedID { get; set; }
        public Nullable<decimal> WaterFee { get; set; }
        public Nullable<decimal> ElectricFee { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string HappenTime { get; set; }
        public Nullable<bool> IsCharge { get; set; }
        public int InHydropowerID { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class inHyDropowerDetail
    {
        public int ID { get; set; }
        public int HyDropowerID { get; set; }
        public int LshydropowerType { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public int ElectricNumbers { get; set; }
        public virtual InHydropowerRecord InHydropowerRecord { get; set; }
    }
}

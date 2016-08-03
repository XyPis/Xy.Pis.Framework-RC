using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwInPatientCharge
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string InPatNo { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Sex { get; set; }
        public string BedAddress { get; set; }
        public decimal Prepaid { get; set; }
        public decimal Unliquidated { get; set; }
    }
}

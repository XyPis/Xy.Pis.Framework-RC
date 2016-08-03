using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CKMachineFluid
    {
        public int ID { get; set; }
        public int MachineID { get; set; }
        public int BodyFluidId { get; set; }
        public string MachineFluidCode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CKMachineResultDtl
    {
        public int ID { get; set; }
        public int ResultID { get; set; }
        public int TestID { get; set; }
        public string Result { get; set; }
        public string bench { get; set; }
        public virtual CKMachineResult CKMachineResult { get; set; }
    }
}

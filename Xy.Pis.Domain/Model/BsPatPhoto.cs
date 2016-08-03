using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsPatPhoto
    {
        public int ID { get; set; }
        public Nullable<int> PatId { get; set; }
        public byte[] Image { get; set; }
        public virtual BsPatient BsPatient { get; set; }
    }
}

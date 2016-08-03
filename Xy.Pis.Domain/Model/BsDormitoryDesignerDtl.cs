using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsDormitoryDesignerDtl
    {
        public int ID { get; set; }
        public int DesignerID { get; set; }
        public string Name { get; set; }
        public Nullable<short> OrderBy { get; set; }
    }
}

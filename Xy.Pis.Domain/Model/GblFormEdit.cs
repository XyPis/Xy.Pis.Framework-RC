using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblFormEdit
    {
        public int ID { get; set; }
        public string FormName { get; set; }
        public string FiledName { get; set; }
        public Nullable<bool> IsAdd { get; set; }
        public string ToolTip { get; set; }
        public Nullable<bool> IsExcept { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

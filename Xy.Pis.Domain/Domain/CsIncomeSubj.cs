using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CsIncomeSubj
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<short> OrderBy { get; set; }
    }
}

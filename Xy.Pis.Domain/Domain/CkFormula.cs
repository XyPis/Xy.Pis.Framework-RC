using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CkFormula
    {
        public int ID { get; set; }
        public int TestId { get; set; }
        public string Formula { get; set; }
        public string Memo { get; set; }
    }
}

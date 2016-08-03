using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoPay
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int InvoId { get; set; }
        public decimal Amount { get; set; }
        public int PayWayId { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<int> SerialNum { get; set; }
    }
}

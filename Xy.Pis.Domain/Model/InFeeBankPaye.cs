using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InFeeBankPaye
    {
        public int ID { get; set; }
        public int HospID { get; set; }
        public int PayWayId { get; set; }
        public string BankAccount { get; set; }
        public string Consignor { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Memo { get; set; }
    }
}

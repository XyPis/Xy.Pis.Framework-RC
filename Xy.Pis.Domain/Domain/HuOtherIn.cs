using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class HuOtherIn
    {
        public HuOtherIn()
        {
            this.HuOtherInDtls = new List<HuOtherInDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> LocationId { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuOtherInDtl> HuOtherInDtls { get; set; }
    }
}

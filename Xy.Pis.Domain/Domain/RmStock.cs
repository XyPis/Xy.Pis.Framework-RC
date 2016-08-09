using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class RmStock
    {
        public RmStock()
        {
            this.RmStockDtls = new List<RmStockDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public int CompId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string Memo { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<RmStockDtl> RmStockDtls { get; set; }
    }
}

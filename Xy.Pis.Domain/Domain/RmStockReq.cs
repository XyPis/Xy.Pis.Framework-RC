using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class RmStockReq
    {
        public RmStockReq()
        {
            this.RmStockReqdtls = new List<RmStockReqdtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public Nullable<int> CompId { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<System.DateTime> ValideTime { get; set; }
        public string ApplyIdea { get; set; }
        public string ApplyHander { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<RmStockReqdtl> RmStockReqdtls { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmLaundry : EntityBase
    {
        public LmLaundry()
        {
            this.LmLaundryDtls = new List<LmLaundryDtl>();
        }

        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> DeliveryOperId { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }
        public Nullable<int> ReceivingOperId { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> LsStatus { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual BsUser BsUser2 { get; set; }
        public virtual ICollection<LmLaundryDtl> LmLaundryDtls { get; set; }
    }
}

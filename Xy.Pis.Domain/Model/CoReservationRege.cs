using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoReservationRege
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LsIntention { get; set; }
        public Nullable<int> PatientSourceCanalId { get; set; }
        public string FloorName { get; set; }
        public string RoomNo { get; set; }
        public string BedName { get; set; }
        public string ConsultantName { get; set; }
        public string ConsultPhone { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public string ReceptionPerson { get; set; }
        public string HomeAddress { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public decimal PrepayAmount { get; set; }
        public string PrepayMemo { get; set; }
        public bool IsPay { get; set; }
        public Nullable<decimal> CancelPrepayAmount { get; set; }
        public string CancelPrepayMemo { get; set; }
        public Nullable<bool> IsCancelPay { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}

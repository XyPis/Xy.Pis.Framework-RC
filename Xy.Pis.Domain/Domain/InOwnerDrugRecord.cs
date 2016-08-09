using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InOwnerDrugRecord
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string SpecDosage { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public decimal RemainTotality { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsStopSend { get; set; }
        public Nullable<System.DateTime> StopSendTime { get; set; }
        public Nullable<int> StopSendOperID { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public string Memo { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}

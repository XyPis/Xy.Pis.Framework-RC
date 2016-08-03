using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InOwnerDrugLog
    {
        public int ID { get; set; }
        public int RecordId { get; set; }
        public int LsOwnerDrugOperType { get; set; }
        public decimal OperDosage { get; set; }
        public decimal OperTimes { get; set; }
        public decimal OperTotality { get; set; }
        public decimal OperBeforeTotality { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public System.DateTime ExecuteStopTime { get; set; }
        public string Memo { get; set; }
    }
}

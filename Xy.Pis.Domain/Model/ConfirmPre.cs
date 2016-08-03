using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class ConfirmPre
    {
        public string Presno { get; set; }
        public System.DateTime PresDate { get; set; }
        public int WindowNO { get; set; }
        public string PatientID { get; set; }
        public string Flag { get; set; }
        public string FPNO { get; set; }
        public int ID { get; set; }
    }
}

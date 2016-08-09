using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class TrDoctorEmr
    {
        public int ID { get; set; }
        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int PatID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsPatient BsPatient { get; set; }
    }
}

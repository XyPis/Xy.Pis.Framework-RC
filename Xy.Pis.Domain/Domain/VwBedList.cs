using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwBedList
    {
        public string BedName { get; set; }
        public short LsBALL { get; set; }
        public string PatientName { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
    }
}

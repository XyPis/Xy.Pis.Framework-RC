using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CKMachineNoPassage
    {
        public int ID { get; set; }
        public int MachineID { get; set; }
        public string PassAgeNum { get; set; }
        public string TestResuslt { get; set; }
        public Nullable<System.DateTime> ResultDate { get; set; }
    }
}

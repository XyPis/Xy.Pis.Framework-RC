using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class EqAttach
    {
        public int ID { get; set; }
        public int EquipmentId { get; set; }
        public string FileName { get; set; }
        public string LsFileType { get; set; }
        public byte[] AttachFile { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}

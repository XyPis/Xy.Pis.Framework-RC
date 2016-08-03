using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class LmFood1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> LsClass { get; set; }
        public string lsAction { get; set; }
        public string Effect { get; set; }
        public byte[] Photo { get; set; }
        public string TimeFrame { get; set; }
        public string Remark { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int ModifierId { get; set; }
        public System.DateTime ModifyTime { get; set; }
    }
}

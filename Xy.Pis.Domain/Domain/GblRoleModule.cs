using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblRoleModule
    {
        public int ID { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual GblModule GblModule { get; set; }
        public virtual GblRole GblRole { get; set; }
    }
}

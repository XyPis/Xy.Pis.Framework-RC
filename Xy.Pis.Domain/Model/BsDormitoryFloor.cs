using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsDormitoryFloor
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
    }
}

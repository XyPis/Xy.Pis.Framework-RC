using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsBaseCheck
    {
        public BsBaseCheck()
        {
            this.DgIllCures = new List<DgIllCure>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public string Memo { get; set; }
        public Nullable<int> GroupMainId { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public Nullable<int> GroupSubId2 { get; set; }
        public string EngDesc { get; set; }
        public Nullable<short> LsYbType { get; set; }
        public string YbMemo { get; set; }
        public virtual ICollection<DgIllCure> DgIllCures { get; set; }
    }
}

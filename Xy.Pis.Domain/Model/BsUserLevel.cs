using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsUserLevel
    {
        public BsUserLevel()
        {
            this.BsUsers = new List<BsUser>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> IconIndex { get; set; }
        public virtual ICollection<BsUser> BsUsers { get; set; }
    }
}

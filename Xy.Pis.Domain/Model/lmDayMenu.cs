using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmDayMenu : EntityBase
    {
        public LmDayMenu()
        {
            this.lmDayMenuFoods = new List<LmDayMenuFood>();
        }

        public int Id { get; set; }
        public Nullable<int> wfID { get; set; }
        public Nullable<System.DateTime> lsDate { get; set; }
        public virtual ICollection<LmDayMenuFood> lmDayMenuFoods { get; set; }
        public virtual LmWeekFood lmWeekFood { get; set; }
    }
}

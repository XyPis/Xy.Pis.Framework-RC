using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmDayMenuFood : EntityBase
    {
        public int Id { get; set; }
        public Nullable<int> dmId { get; set; }
        public Nullable<int> fId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int lsClass { get; set; }
        public virtual LmDayMenu lmDayMenu { get; set; }
        public virtual LmFood lmFood { get; set; }
    }
}

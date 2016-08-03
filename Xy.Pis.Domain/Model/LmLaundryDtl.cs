using System;
using System.Collections.Generic;
using Xy.Pis.Contract;

namespace Xy.Pis.Domain
{
    public partial class LmLaundryDtl : EntityBase
    {
        public int ID { get; set; }
        public Nullable<int> LaundryId { get; set; }
        public Nullable<int> ClothingId { get; set; }
        public string Spec { get; set; }
        public string UnitName { get; set; }
        public Nullable<int> Totality { get; set; }
        public Nullable<int> BackTotality { get; set; }
        public Nullable<bool> IsAlso { get; set; }
        public string Memo { get; set; }
        public virtual BsClothing BsClothing { get; set; }
        public virtual LmLaundry LmLaundry { get; set; }
    }
}

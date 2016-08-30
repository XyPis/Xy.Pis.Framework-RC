using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class LmFood : EntityBase
    {
        public LmFood()
        {
            this.AdditionalMealDetails = new List<AdditionalMealDetails>();
        }

        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public int? LsClass { get; set; }
        
        public string LsAction { get; set; }
        
        public string Effect { get; set; }
        
        public byte[] Photo { get; set; }
        
        public string TimeFrame { get; set; }
        
        public string Remark { get; set; }
        
        public int CreatorId { get; set; }
        
        public System.DateTime CreateTime { get; set; }
        
        public int ModifierId { get; set; }
        
        public System.DateTime ModifyTime { get; set; }
        
        public string PyCode { get; set; }
        
        public string WbCode { get; set; }
        
        public int? ItemId { get; set; }

        public virtual BsItem BsItem { get; set; }
        
        public virtual ICollection<AdditionalMealDetails> AdditionalMealDetails { get; set; }
    }
}

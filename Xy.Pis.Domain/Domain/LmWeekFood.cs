using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class LmWeekFood : EntityBase
    {
        public int Id { get; set; }
        
        public string LsData { get; set; }
        
        public int? CreatorId { get; set; }
        
        public System.DateTime CreateTime { get; set; }
        
        public System.DateTime LastModifyTime { get; set; }
        
        public int? LastModify { get; set; }
                
        public System.DateTime StartDate { get; set; }
        
        public System.DateTime EndDate { get; set; }
        
        public string PyCode { get; set; }
        
        public string WbCode { get; set; }
    }
}

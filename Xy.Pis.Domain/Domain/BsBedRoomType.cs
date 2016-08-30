using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsBedRoomType
    {
        public int ID { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public int? ItemId { get; set; }
                
        public short BackDays { get; set; }
        
        public decimal PriceIn { get; set; }
        
        public string WbCode { get; set; }

        public string PyCode { get; set; }
        
        public short OrderBy { get; set; }
        
        public bool IsActive { get; set; }
    }
}

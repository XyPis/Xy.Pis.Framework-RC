using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class LocationEquipment : EntityBase 
    {
        public int ID { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string Spec { get; set; }
        
        public int? Type { get; set; }
        
        public string UseLocation { get; set; }
        
        public int? ManageManId { get; set; }
        
        public string StorageLocation { get; set; }
        
        public DateTime? BuyInDate { get; set; }
        
        public int Num { get; set; }
        
        public decimal Price { get; set; }
        
        public decimal Amount { get; set; }
        
        public string HasUsedTime { get; set; }
        
        public DateTime? OperTime { get; set; }
        
        public string VoucherNo { get; set; }
        
        public string SourcesOfFunds { get; set; }
        
        public string Memo { get; set; }
    }
}

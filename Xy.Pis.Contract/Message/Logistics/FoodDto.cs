using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class FoodDTO : DTOBase
    {        
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public int? Type { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }
    }
}

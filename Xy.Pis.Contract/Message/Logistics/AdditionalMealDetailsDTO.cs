using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class AdditionalMealDetailsDTO : DTOBase
    {
        [DataMember]
        public int AdditionalMealId { get; set; }

        [DataMember]
        public int FoodId { get; set; }

        [DataMember]
        public int Qty { get; set; }

        [DataMember]
        public string AdditionalMealType { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }

        [DataMember]
        public virtual FoodDTO Food { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class FixedAssetsDTO : DTOBase
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public Nullable<int> Type { get; set; }

        [DataMember]
        public string UserLocation { get; set; }

        [DataMember]
        public Nullable<int> ResponsibilityId { get; set; }

        [DataMember]
        public string PlacementLoc { get; set; }

        [DataMember]
        public Nullable<System.DateTime> PurchaseDate { get; set; }

        [DataMember]
        public int Qty { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public decimal TotalAmount { get; set; }

        [DataMember]
        public string HasUsedTime { get; set; }

        [DataMember]
        public Nullable<System.DateTime> OperTime { get; set; }

        [DataMember]
        public string VoucherNo { get; set; }

        [DataMember]
        public string SourcesOfFunds { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }

}

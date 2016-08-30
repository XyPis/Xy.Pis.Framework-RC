using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xy.Pis.Contract.Message.Logistics
{
    [DataContract]
    public partial class FixedAssetsDTO : DTOBase
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public int? Type { get; set; }

        [DataMember]
        public string UseLocation { get; set; }

        [DataMember]
        public int? ManageManId { get; set; }

        [DataMember]
        public string StorageLocation { get; set; }

        [DataMember]
        public DateTime? BuyInDate { get; set; }

        [DataMember]
        public int Num { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public string HasUsedTime { get; set; }

        [DataMember]
        public DateTime? OperTime { get; set; }

        [DataMember]
        public string VoucherNo { get; set; }

        [DataMember]
        public string SourcesOfFunds { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}

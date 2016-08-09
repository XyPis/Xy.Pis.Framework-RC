using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoRenewContract
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> BedYearTypeId { get; set; }
        public Nullable<System.DateTime> AgreementBeginDate { get; set; }
        public Nullable<System.DateTime> AgreementEndDate { get; set; }
        public Nullable<bool> IsFirst { get; set; }
        public Nullable<int> NewBedYearTypeId { get; set; }
        public Nullable<System.DateTime> NewAgreementBeginDate { get; set; }
        public Nullable<System.DateTime> NewAgreementEndDate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
    }
}

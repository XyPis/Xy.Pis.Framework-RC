using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InRenewOldInfo
    {
        public int ID { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<int> NursingGradeId { get; set; }
        public string FirstLinkmanName { get; set; }
        public Nullable<int> FirstRelationId { get; set; }
        public string FirstLinkmanIdCard { get; set; }
        public string FirstLinkManWorkUnit { get; set; }
        public string FirstLinkmanUnitAddress { get; set; }
        public string FirstLinkmanFamilyAddress { get; set; }
        public string FirstLinkmanFamilyPhone { get; set; }
        public string FirstLinkmanPhone { get; set; }
        public string SecondLinkmanName { get; set; }
        public Nullable<int> SecondRelationId { get; set; }
        public string SecondLinkmanIdCard { get; set; }
        public string SecondLinkManWorkUnit { get; set; }
        public string SecondLinkmanUnitAddress { get; set; }
        public string SecondLinkmanFamilyAddress { get; set; }
        public string SecondLinkmanFamilyPhone { get; set; }
        public string SecondLinkmanPhone { get; set; }
        public Nullable<int> BedYearTypeId { get; set; }
        public Nullable<short> LsOutManagementType { get; set; }
        public Nullable<int> AddRatioId { get; set; }
        public Nullable<short> LsEconomicSource { get; set; }
        public Nullable<int> MealTypeId { get; set; }
        public Nullable<int> ServiceChargeId { get; set; }
        public Nullable<System.DateTime> AgreementBeginDate { get; set; }
        public Nullable<System.DateTime> AgreementEndDate { get; set; }
        public Nullable<bool> IsCheckInCharge { get; set; }
        public Nullable<decimal> OneTimeFacilityFee { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> ServiceChargeAmount { get; set; }
    }
}

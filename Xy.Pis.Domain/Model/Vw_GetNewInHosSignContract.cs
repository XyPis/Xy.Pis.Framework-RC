using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class Vw_GetNewInHosSignContract
    {
        public int HospId { get; set; }
        public Nullable<bool> IsCheckInAgree { get; set; }
        public Nullable<bool> IsPurchaseCost { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string InPatNo { get; set; }
        public string AgeString { get; set; }
        public string IdCardNo { get; set; }
        public string HouseRegAddress { get; set; }
        public string PresentAddress { get; set; }
        public string FirstLinkmanName { get; set; }
        public string FirstRelationName { get; set; }
        public string FirstLinkmanIdCard { get; set; }
        public string FirstLinkManWorkUnit { get; set; }
        public string FirstLinkmanUnitAddress { get; set; }
        public string FirstLinkmanFamilyAddress { get; set; }
        public string FirstLinkmanFamilyPhone { get; set; }
        public string FirstLinkmanPhone { get; set; }
        public string SecondLinkmanName { get; set; }
        public string SecondRelationName { get; set; }
        public string SecondLinkmanIdCard { get; set; }
        public string SecondLinkManWorkUnit { get; set; }
        public string SecondLinkmanUnitAddress { get; set; }
        public string SecondLinkmanFamilyAddress { get; set; }
        public string SecondLinkmanFamilyPhone { get; set; }
        public string SecondLinkmanPhone { get; set; }
        public string BedRoomTypeName { get; set; }
        public string BedAddress { get; set; }
        public string BedYearTypeName { get; set; }
        public string NursingGradeName { get; set; }
        public Nullable<decimal> BedRoomTypePriceIn { get; set; }
        public decimal MealTypePriceIn { get; set; }
        public Nullable<decimal> NursingGradePriceIn { get; set; }
        public decimal ServiceChargePriceIn { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public string OutManagementType { get; set; }
        public Nullable<decimal> OneLifeFacFee { get; set; }
        public System.DateTime InTime { get; set; }
        public string LsMarriageName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Native { get; set; }
        public string EduLevel { get; set; }
        public Nullable<System.DateTime> AgreementBeginDate { get; set; }
        public Nullable<System.DateTime> AgreementEndDate { get; set; }
        public decimal SelfDrugPriceIn { get; set; }
        public decimal SelfClothesPriceIn { get; set; }
        public decimal SelfNursePriceIn { get; set; }
        public string PhoneHome { get; set; }
        public int HosRenewId { get; set; }
        public Nullable<int> Frequency { get; set; }
        public Nullable<bool> IsRoomFloor { get; set; }
        public string EatingHabits { get; set; }
        public string MealTypeOtherMemo { get; set; }
        public string ChargeNotice { get; set; }
        public Nullable<bool> IsCantonese { get; set; }
        public Nullable<bool> IsMandarin { get; set; }
        public string OtherLanguages { get; set; }
        public string OtherServices { get; set; }
        public string PersonalPreference { get; set; }
        public string ServicePhysicalCondition { get; set; }
        public string OtherExplain { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
    }
}

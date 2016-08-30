using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InHosInfo : EntityBase
    {
        public InHosInfo()
        {
            this.AdditionalMeals = new List<AdditionalMeal>();
        }

        public int ID { get; set; }
        
        public string HospNo { get; set; }
        
        public int PatID { get; set; }
        
        public string InPatNo { get; set; }
        
        public string CardNo { get; set; }
        
        public string Name { get; set; }
        
        public string Sex { get; set; }
        
        public int NTime { get; set; }
        
        public DateTime? InTime { get; set; }
        
        public DateTime? OutTime { get; set; }
        
        public short? LsMarriage { get; set; }
        
        public string BloodGroup { get; set; }
        
        public int? CountryId { get; set; }
        
        public string Residence { get; set; }
        
        public string City { get; set; }
        
        public string Province { get; set; }
        
        public bool IsOversea { get; set; }
        
        public DateTime? PassTime { get; set; }
        
        public string IdCardNo { get; set; }
        
        public string Company { get; set; }
        
        public string Occupation { get; set; }
        
        public int? WorktypeId { get; set; }
        
        public int PatTypeId { get; set; }
        
        public int? CertificateId { get; set; }
        
        public short? LsInType { get; set; }
        
        public short? LsInWay { get; set; }
        
        public short? LsInIllness { get; set; }
        
        public int? DocMz { get; set; }
        
        public int? DoctorId { get; set; }
        
        public int LocIn { get; set; }
        
        public int? LocationId { get; set; }
        
        public bool IsYbMt { get; set; }
        
        public string YbRegNo { get; set; }
        
        public decimal? ArrearAmount { get; set; }
        
        public decimal? Height { get; set; }
        
        public decimal? Weight { get; set; }
        
        public string PhoneHome { get; set; }
        
        public string AddressHome { get; set; }
        
        public string PostCodeHome { get; set; }
        
        public string AreaCodeHome { get; set; }
        
        public string PhoneWork { get; set; }
        
        public string AddressWork { get; set; }
        
        public string PostCodeWork { get; set; }
        
        public string AreaCodeWork { get; set; }
        
        public string LinkmanName { get; set; }
        
        public int? RelationId { get; set; }
        
        public string LinkmanPhone { get; set; }
        
        public string LinkmanAddress { get; set; }
        
        public string LinkmanPost { get; set; }
        
        public string LinkmanArea { get; set; }
        
        public short LsInStatus { get; set; }
        
        public DateTime? LeaveTime { get; set; }
        
        public string Status { get; set; }
        
        public System.DateTime OperTime { get; set; }
        
        public int OperID { get; set; }
        
        public bool IsEndChg { get; set; }
        
        public int? EndChgOperID { get; set; }
        
        public DateTime? EndchgoperTime { get; set; }
        
        public string AgeString { get; set; }
        
        public string PyCode { get; set; }
        
        public int? BedId { get; set; }
        
        public int? NursingGradeId { get; set; }
        
        public string FirstLinkmanName { get; set; }
        
        public int? FirstRelationId { get; set; }
        
        public string FirstLinkmanIdCard { get; set; }
        
        public string FirstLinkManWorkUnit { get; set; }
        
        public string FirstLinkmanUnitAddress { get; set; }
        
        public string FirstLinkmanFamilyAddress { get; set; }
        
        public string FirstLinkmanFamilyPhone { get; set; }
        
        public string FirstLinkmanPhone { get; set; }
        
        public string SecondLinkmanName { get; set; }
        
        public int? SecondRelationId { get; set; }
        
        public string SecondLinkmanIdCard { get; set; }
        
        public string SecondLinkManWorkUnit { get; set; }
        
        public string SecondLinkmanUnitAddress { get; set; }
        
        public string SecondLinkmanFamilyAddress { get; set; }
        
        public string SecondLinkmanFamilyPhone { get; set; }
        
        public string SecondLinkmanPhone { get; set; }
        
        public int? BedYearTypeId { get; set; }
        
        public short? LsOutManagementType { get; set; }
        
        public int? AddRatioId { get; set; }
        
        public short? LsEconomicSource { get; set; }
        
        public int? MealTypeId { get; set; }
        
        public int? ServiceChargeId { get; set; }
        
        public DateTime? AgreementBeginDate { get; set; }
        
        public DateTime? AgreementEndDate { get; set; }
        
        public bool IsCheckInCharge { get; set; }
        
        public decimal? OneTimeFacilityFee { get; set; }
        
        public decimal? Discount { get; set; }
        
        public decimal? ServiceChargeAmount { get; set; }
        
        public decimal? BedAmount { get; set; }
        
        public decimal? NursingCost { get; set; }
        
        public virtual BsBed BedInfo { get; set; }
        
        public virtual ICollection<AdditionalMeal> AdditionalMeals { get; set; }
    }
}

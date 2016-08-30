using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message
{
    [DataContract]
    public partial class InHosInfoDTO : DTOBase
    {
        public InHosInfoDTO()
        {
            this.AdditionalMeals = new List<Logistics.AdditionalMealDTO>();
        }

        [DataMember]
        public string HospNo { get; set; }

        [DataMember]
        public int PatID { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public int NTime { get; set; }

        [DataMember]
        public DateTime? InTime { get; set; }

        [DataMember]
        public DateTime? OutTime { get; set; }

        [DataMember]
        public short? LsMarriage { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public int? CountryId { get; set; }
        
        [DataMember]
        public string Residence { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Province { get; set; }
        
        [DataMember]
        public bool IsOversea { get; set; }

        [DataMember]
        public DateTime? PassTime { get; set; }

        [DataMember]
        public string IdCardNo { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public int? WorktypeId { get; set; }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public int? CertificateId { get; set; }

        [DataMember]
        public short? LsInType { get; set; }

        [DataMember]
        public short? LsInWay { get; set; }

        [DataMember]
        public short? LsInIllness { get; set; }

        [DataMember]
        public int? DocMz { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int LocIn { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public bool IsYbMt { get; set; }

        [DataMember]
        public string YbRegNo { get; set; }

        [DataMember]
        public decimal? ArrearAmount { get; set; }

        [DataMember]
        public decimal? Height { get; set; }

        [DataMember]
        public decimal? Weight { get; set; }

        [DataMember]
        public string PhoneHome { get; set; }

        [DataMember]
        public string AddressHome { get; set; }

        [DataMember]
        public string PostCodeHome { get; set; }

        [DataMember]
        public string AreaCodeHome { get; set; }

        [DataMember]
        public string PhoneWork { get; set; }

        [DataMember]
        public string AddressWork { get; set; }

        [DataMember]
        public string PostCodeWork { get; set; }

        [DataMember]
        public string AreaCodeWork { get; set; }

        [DataMember]
        public string LinkmanName { get; set; }

        [DataMember]
        public int? RelationId { get; set; }

        [DataMember]
        public string LinkmanPhone { get; set; }

        [DataMember]
        public string LinkmanAddress { get; set; }

        [DataMember]
        public string LinkmanPost { get; set; }

        [DataMember]
        public string LinkmanArea { get; set; }

        [DataMember]
        public short LsInStatus { get; set; }

        [DataMember]
        public DateTime? LeaveTime { get; set; }

        [DataMember]
        public string Status { get; set; }
        
        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperID { get; set; }

        [DataMember]
        public bool IsEndChg { get; set; }

        [DataMember]
        public int? EndChgOperID { get; set; }

        [DataMember]
        public DateTime? EndchgoperTime { get; set; }

        [DataMember]
        public string AgeString { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public int? BedId { get; set; }

        [DataMember]
        public int? NursingGradeId { get; set; }

        [DataMember]
        public string FirstLinkmanName { get; set; }

        [DataMember]
        public int? FirstRelationId { get; set; }

        [DataMember]
        public string FirstLinkmanIdCard { get; set; }

        [DataMember]
        public string FirstLinkManWorkUnit { get; set; }

        [DataMember]
        public string FirstLinkmanUnitAddress { get; set; }

        [DataMember]
        public string FirstLinkmanFamilyAddress { get; set; }

        [DataMember]
        public string FirstLinkmanFamilyPhone { get; set; }

        [DataMember]
        public string FirstLinkmanPhone { get; set; }

        [DataMember]
        public string SecondLinkmanName { get; set; }

        [DataMember]
        public int? SecondRelationId { get; set; }

        [DataMember]
        public string SecondLinkmanIdCard { get; set; }

        [DataMember]
        public string SecondLinkManWorkUnit { get; set; }

        [DataMember]
        public string SecondLinkmanUnitAddress { get; set; }

        [DataMember]
        public string SecondLinkmanFamilyAddress { get; set; }

        [DataMember]
        public string SecondLinkmanFamilyPhone { get; set; }

        [DataMember]
        public string SecondLinkmanPhone { get; set; }
        
        [DataMember]
        public int? BedYearTypeId { get; set; }

        [DataMember]
        public short? LsOutManagementType { get; set; }

        [DataMember]
        public int? AddRatioId { get; set; }

        [DataMember]
        public short? LsEconomicSource { get; set; }

        [DataMember]
        public int? MealTypeId { get; set; }

        [DataMember]
        public int? ServiceChargeId { get; set; }

        [DataMember]
        public DateTime? AgreementBeginDate { get; set; }

        [DataMember]
        public DateTime? AgreementEndDate { get; set; }

        [DataMember]
        public bool IsCheckInCharge { get; set; }

        [DataMember]
        public decimal? OneTimeFacilityFee { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }

        [DataMember]
        public decimal? ServiceChargeAmount { get; set; }
        
        [DataMember]
        public decimal? BedAmount { get; set; }

        [DataMember]
        public decimal? NursingCost { get; set; }

        [DataMember]
        public virtual ICollection<Logistics.AdditionalMealDTO> AdditionalMeals { get; set; }
    }
}

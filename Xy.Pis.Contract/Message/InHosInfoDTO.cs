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
        public int ID { get; set; }

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
        public Nullable<System.DateTime> InTime { get; set; }

        [DataMember]
        public Nullable<System.DateTime> OutTime { get; set; }

        [DataMember]
        public Nullable<short> LsMarriage { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public Nullable<int> CountryId { get; set; }
        
        [DataMember]
        public string Residence { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Province { get; set; }
        
        [DataMember]
        public bool IsOversea { get; set; }

        [DataMember]
        public Nullable<System.DateTime> PassTime { get; set; }

        [DataMember]
        public string IdCardNo { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Occupation { get; set; }

        [DataMember]
        public Nullable<int> WorktypeId { get; set; }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public Nullable<int> CertificateId { get; set; }

        [DataMember]
        public Nullable<short> LsInType { get; set; }

        [DataMember]
        public Nullable<short> LsInWay { get; set; }

        [DataMember]
        public Nullable<short> LsInIllness { get; set; }

        [DataMember]
        public Nullable<int> DocMz { get; set; }

        [DataMember]
        public Nullable<int> DoctorId { get; set; }

        [DataMember]
        public int LocIn { get; set; }

        [DataMember]
        public Nullable<int> LocationId { get; set; }

        [DataMember]
        public bool IsYbMt { get; set; }

        [DataMember]
        public string YbRegNo { get; set; }

        [DataMember]
        public Nullable<decimal> ArrearAmount { get; set; }

        [DataMember]
        public Nullable<decimal> Height { get; set; }

        [DataMember]
        public Nullable<decimal> Weight { get; set; }

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
        public Nullable<int> RelationId { get; set; }

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
        public Nullable<System.DateTime> LeaveTime { get; set; }

        [DataMember]
        public string Status { get; set; }
        
        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperID { get; set; }

        [DataMember]
        public bool IsEndChg { get; set; }

        [DataMember]
        public Nullable<int> EndChgOperID { get; set; }

        [DataMember]
        public Nullable<System.DateTime> EndchgoperTime { get; set; }

        [DataMember]
        public string AgeString { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public Nullable<int> BedId { get; set; }

        [DataMember]
        public Nullable<int> NursingGradeId { get; set; }

        [DataMember]
        public string FirstLinkmanName { get; set; }

        [DataMember]
        public Nullable<int> FirstRelationId { get; set; }

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
        public Nullable<int> SecondRelationId { get; set; }

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
        public Nullable<int> BedYearTypeId { get; set; }

        [DataMember]
        public Nullable<short> LsOutManagementType { get; set; }

        [DataMember]
        public Nullable<int> AddRatioId { get; set; }

        [DataMember]
        public Nullable<short> LsEconomicSource { get; set; }

        [DataMember]
        public Nullable<int> MealTypeId { get; set; }

        [DataMember]
        public Nullable<int> ServiceChargeId { get; set; }

        [DataMember]
        public Nullable<System.DateTime> AgreementBeginDate { get; set; }

        [DataMember]
        public Nullable<System.DateTime> AgreementEndDate { get; set; }

        [DataMember]
        public bool IsCheckInCharge { get; set; }

        [DataMember]
        public Nullable<decimal> OneTimeFacilityFee { get; set; }

        [DataMember]
        public Nullable<decimal> Discount { get; set; }

        [DataMember]
        public Nullable<decimal> ServiceChargeAmount { get; set; }
        
        [DataMember]
        public Nullable<decimal> BedAmount { get; set; }

        [DataMember]
        public Nullable<decimal> NursingCost { get; set; }

        [DataMember]
        public virtual ICollection<Logistics.AdditionalMealDTO> AdditionalMeals { get; set; }
    }
}

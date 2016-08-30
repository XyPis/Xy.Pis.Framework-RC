using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message
{
    [DataContract]
    public partial class LocationDTO : DTOBase
    {
        public LocationDTO()
        {
            this.AdditionalMeals = new List<Logistics.AdditionalMealDTO>();
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public short LsInOut { get; set; }

        [DataMember]
        public bool IsForwomen { get; set; }

        [DataMember]
        public string PhoneCode { get; set; }

        [DataMember]
        public decimal MedicineRatio { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public int? SpecialityId { get; set; }

        [DataMember]
        public short? BedSum { get; set; }

        [DataMember]
        public string BaSysCode { get; set; }

        [DataMember]
        public string Director { get; set; }

        [DataMember]
        public int? DeptTypeId { get; set; }

        [DataMember]
        public bool? IsCostApp { get; set; }

        [DataMember]
        public short? AppLevel { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public int? Area { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public int? OuRoomId { get; set; }

        [DataMember]
        public int? InRoomId { get; set; }

        [DataMember]
        public bool? IsPriceSub { get; set; }
        
        [DataMember]
        public virtual ICollection<Logistics.AdditionalMealDTO> AdditionalMeals { get; set; }
    }
}

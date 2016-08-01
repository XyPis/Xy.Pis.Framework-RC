using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xy.Pis.Contract.Message
{
    [DataContract]
    public partial class UserDTO : DTOBase
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Code { get; set; }
        
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string Password { get; set; }
        
        [DataMember]
        public bool IsActive { get; set; }
        
        [DataMember]
        public string Reason { get; set; }
        
        [DataMember]
        public short LsInputWay { get; set; }
        
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
        public Nullable<bool> IsUserInputWB { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputPY { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputCode { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputName { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputStrokeCode { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputEngDesc { get; set; }
        
        [DataMember]
        public string Introduce { get; set; }
        
        [DataMember]
        public string PicturePath { get; set; }
        
        [DataMember]
        public string Address { get; set; }
        
        [DataMember]
        public string Mobile { get; set; }
        
        [DataMember]
        public Nullable<int> LevelId { get; set; }
        
        [DataMember]
        public Nullable<int> DocLevId { get; set; }
        
        [DataMember]
        public Nullable<int> HospitalId { get; set; }
        
        [DataMember]
        public Nullable<int> CareGroupId { get; set; }
        
        [DataMember]
        public Nullable<int> CareGroupId1 { get; set; }
        
        [DataMember]
        public string F5 { get; set; }
        
        [DataMember]
        public string CertIdNo { get; set; }
        
        [DataMember]
        public string PyCode { get; set; }
        
        [DataMember]
        public string WbCode { get; set; }
        
        [DataMember]
        public Nullable<bool> IsUserInputF1 { get; set; }
        
        [DataMember]
        public Nullable<int> UserLevelId { get; set; }
    }
}

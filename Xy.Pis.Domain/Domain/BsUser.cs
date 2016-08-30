using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsUser : EntityBase
    {
        public BsUser()
        {
        }

        public int ID { get; set; }

        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string Password { get; set; }
        
        public bool IsActive { get; set; }
        
        public string Reason { get; set; }
        
        public short LsInputWay { get; set; }
        
        public string F1 { get; set; }
        
        public string F2 { get; set; }
        
        public string F3 { get; set; }
        
        public string F4 { get; set; }
        
        public short IconIndex { get; set; }
        
        public bool? IsUserInputWB { get; set; }
        
        public bool? IsUserInputPY { get; set; }
        
        public bool? IsUserInputCode { get; set; }
        
        public bool? IsUserInputName { get; set; }
        
        public bool? IsUserInputStrokeCode { get; set; }
        
        public bool? IsUserInputEngDesc { get; set; }
        
        public string Introduce { get; set; }
        
        public string PicturePath { get; set; }
        
        public string Address { get; set; }
        
        public string Mobile { get; set; }
        
        public int? LevelId { get; set; }
        
        public int? DocLevId { get; set; }
        
        public int? HospitalId { get; set; }
        
        public int? CareGroupId { get; set; }
        
        public int? CareGroupId1 { get; set; }
        
        public string F5 { get; set; }
        
        public string CertIdNo { get; set; }
        
        public string PyCode { get; set; }
        
        public string WbCode { get; set; }
        
        public bool? IsUserInputF1 { get; set; }
        
        public int? UserLevelId { get; set; }
    }
}

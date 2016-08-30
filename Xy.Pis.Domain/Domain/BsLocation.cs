using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsLocation : EntityBase
    {
        public BsLocation()
        {
            this.EngineeringMaintenances = new List<LmWorkRepair>();
        }

        public int ID { get; set; }

        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public int? HospitalId { get; set; }
        
        public short LsInOut { get; set; }
        
        public bool IsForwomen { get; set; }
        
        public string PhoneCode { get; set; }
        
        public decimal MedicineRatio { get; set; }
        
        public short OrderBy { get; set; }
        
        public bool IsActive { get; set; }
        
        public string F1 { get; set; }
        
        public string F2 { get; set; }
        
        public string F3 { get; set; }
        
        public string F4 { get; set; }
        
        public short IconIndex { get; set; }
        
        public int? SpecialityId { get; set; }
        
        public short? BedSum { get; set; }
        
        public string BaSysCode { get; set; }
        
        public string Director { get; set; }
        
        public int? DeptTypeId { get; set; }
        
        public bool? IsCostApp { get; set; }
        
        public short? AppLevel { get; set; }
        
        public string PyCode { get; set; }
        
        public string WbCode { get; set; }
        
        public int? Area { get; set; }
        
        public string F5 { get; set; }
        
        public string F6 { get; set; }
        
        public string F7 { get; set; }
        
        public string F8 { get; set; }
        
        public int? OuRoomId { get; set; }
        
        public int? InRoomId { get; set; }
        
        public bool? IsPriceSub { get; set; }
        
        public virtual ICollection<LmWorkRepair> EngineeringMaintenances { get; set; }
    }
}

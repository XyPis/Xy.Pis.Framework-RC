using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsBed
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string RoomNo { get; set; }
        
        public int LocationId { get; set; }
        
        public short LsBALL { get; set; }
        
        public int? ItemId { get; set; }
        
        public bool IsAdd { get; set; }
        
        public string Memo { get; set; }

        public int OperID { get; set; }
        
        public System.DateTime OperTime { get; set; }
        
        public short OrderBy { get; set; }
        
        public bool IsActive { get; set; }
        
        public string F1 { get; set; }
        
        public string F2 { get; set; }
        
        public string F3 { get; set; }
        
        public string F4 { get; set; }
        
        public short IconIndex { get; set; }
        
        public short LsClass { get; set; }
        
        public bool? IsAddBed { get; set; }
        
        public int? BsBedDesignerID { get; set; }
        
        public int? FloorNum { get; set; }
        
        public int? BedSerial { get; set; }
        
        public int? BsBedRoomTypeID { get; set; }
        
        public bool? IsWatchRoom { get; set; }
        
        public int? HospId { get; set; }
        
        public virtual BsBedFloor BsBedFloor { get; set; }
    
        public virtual ICollection<InHosInfo> InHosInfos { get; set; }
    }
}

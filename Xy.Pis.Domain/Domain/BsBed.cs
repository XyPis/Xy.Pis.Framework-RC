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
        public Nullable<int> ItemId { get; set; }
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
        public Nullable<bool> IsAddBed { get; set; }
        public Nullable<int> BsBedDesignerID { get; set; }
        public Nullable<int> FloorNum { get; set; }
        public Nullable<int> BedSerial { get; set; }
        public Nullable<int> BsBedRoomTypeID { get; set; }
        public Nullable<bool> IsWatchRoom { get; set; }
        public Nullable<int> HospId { get; set; }
        public virtual BsBedFloor BsBedFloor { get; set; }
        public virtual ICollection<InHosInfo> InHosInfos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InLinkMan
    {
        public int ID { get; set; }
        public string TempLinkmanName { get; set; }
        public Nullable<int> TempRelationId { get; set; }
        public string TempLinkmanIdCard { get; set; }
        public string TempLinkManWorkUnit { get; set; }
        public string TempLinkmanFamilyAddress { get; set; }
        public string TempLinkmanFamilyPhone { get; set; }
        public string TempLinkmanPhone { get; set; }
        public int HospId { get; set; }
    }
}

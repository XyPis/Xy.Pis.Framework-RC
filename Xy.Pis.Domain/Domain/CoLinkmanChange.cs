using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CoLinkmanChange
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LsType { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string LinkmanIdCard { get; set; }
        public string LinkManWorkUnit { get; set; }
        public string LinkmanUnitAddress { get; set; }
        public string LinkmanFamilyAddress { get; set; }
        public string LinkmanFamilyPhone { get; set; }
        public string LinkmanPhone { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsAudit { get; set; }
        public Nullable<int> AuditOperId { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public string Memo { get; set; }
        public string LinkmanNameBefore { get; set; }
        public Nullable<int> RelationIdBefore { get; set; }
        public string LinkmanIdCardBefore { get; set; }
        public string LinkManWorkUnitBefore { get; set; }
        public string LinkmanUnitAddressBefore { get; set; }
        public string LinkmanFamilyAddressBefore { get; set; }
        public string LinkmanFamilyPhoneBefore { get; set; }
        public string LinkmanPhoneBefore { get; set; }
        public Nullable<int> LsChangeType { get; set; }
        public Nullable<int> MealOperId { get; set; }
        public Nullable<System.DateTime> MealTime { get; set; }
    }
}

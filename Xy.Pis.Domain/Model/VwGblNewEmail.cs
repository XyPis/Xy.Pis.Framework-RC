using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwGblNewEmail
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPriority { get; set; }
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<System.DateTime> ReadTime { get; set; }
        public Nullable<int> HospId { get; set; }
    }
}

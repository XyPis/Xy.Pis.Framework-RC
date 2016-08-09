using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblNewEmailUser
    {
        public int ID { get; set; }
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<System.DateTime> ReadTime { get; set; }
        public Nullable<int> ReadUserId { get; set; }
        public virtual GblNewEmail GblNewEmail { get; set; }
    }
}

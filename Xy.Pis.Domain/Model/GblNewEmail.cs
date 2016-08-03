using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblNewEmail
    {
        public GblNewEmail()
        {
            this.GblNewEmailUsers = new List<GblNewEmailUser>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPriority { get; set; }
        public Nullable<int> HospId { get; set; }
        public virtual ICollection<GblNewEmailUser> GblNewEmailUsers { get; set; }
    }
}

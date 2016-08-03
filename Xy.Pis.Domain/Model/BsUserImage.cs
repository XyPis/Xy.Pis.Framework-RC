using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsUserImage
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public byte[] UserImage { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}

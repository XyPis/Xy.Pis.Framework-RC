using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblMessage
    {
        public int ID { get; set; }
        public int LsMessageType { get; set; }
        public string MessageContent { get; set; }
        public string FileName { get; set; }
        public System.DateTime OperTime { get; set; }
        public string SubmitMan { get; set; }
        public int HospId { get; set; }
        public string InPatNo { get; set; }
    }
}

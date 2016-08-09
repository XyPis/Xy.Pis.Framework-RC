using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InNumberOfDiner
    {
        public int ID { get; set; }
        public int NumOfDiners { get; set; }
        public int LocationId { get; set; }
        public System.DateTime EatingTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public bool IsSign { get; set; }
        public int SignOperId { get; set; }
        public System.DateTime SignTime { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}

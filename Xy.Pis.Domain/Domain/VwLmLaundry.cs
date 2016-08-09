using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwLmLaundry
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string BedAdress { get; set; }
        public Nullable<int> DeliveryOperId { get; set; }
        public string DeliveryOperName { get; set; }
        public Nullable<System.DateTime> DeliveryTime { get; set; }
        public Nullable<int> ReceivingOperId { get; set; }
        public string ReceivingOperName { get; set; }
        public Nullable<System.DateTime> ReceivingTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string OperName { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> LsStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InSubsidyMonthDetail
    {
        public int ID { get; set; }
        public int SubsidyYear { get; set; }
        public int HospId { get; set; }
        public decimal JanuarySubsidyId { get; set; }
        public decimal FebruarySubsidyId { get; set; }
        public decimal MarchSubsidyId { get; set; }
        public decimal AprilSubsidyId { get; set; }
        public decimal MaySubsidyId { get; set; }
        public decimal JuneSubsidyId { get; set; }
        public decimal JulySubsidyId { get; set; }
        public decimal AugustSubsidyId { get; set; }
        public decimal SeptemberSubsidyId { get; set; }
        public decimal OctoberSubsidyId { get; set; }
        public decimal NovemberSubsidyId { get; set; }
        public decimal DecemberSubsidyId { get; set; }
        public string Memo { get; set; }
    }
}

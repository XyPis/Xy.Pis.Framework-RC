using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsItem
    {
        public BsItem()
        {
        }

        public int Id { get; set; }
        
        public short LsGroupType { get; set; }
        
        public string Code { get; set; }
        
        public string WbCode { get; set; }

        public string PyCode { get; set; }
        
        public string StrokeCode { get; set; }
        
        public string OtherCode { get; set; }
        
        public int GroupMainId { get; set; }
        
        public int? GroupSubId { get; set; }
        
        public string Name { get; set; }
        
        public string LongDesc { get; set; }
        
        public string EngDesc { get; set; }
        
        public string Spec { get; set; }
        
        public int UnitInId { get; set; }
        
        public decimal PriceIn { get; set; }
        
        public int UnitDiagId { get; set; }
        
        public decimal PriceDiag { get; set; }
        
        public decimal AddPercent { get; set; }
        
        public short LsRpType { get; set; }
        
        public decimal Dosage { get; set; }
        
        public int? UnitTakeId { get; set; }
        
        public int? FrequencyId { get; set; }
        
        public int? UsageId { get; set; }
        
        public int FeeMzId { get; set; }
        
        public int FeeZyId { get; set; }
        
        public short LsGfType { get; set; }
        
        public decimal? GfFixDisc { get; set; }
        
        public bool OptionPrice { get; set; }
        
        public decimal LimitTotalMz { get; set; }
        
        public decimal LimitTotalZy { get; set; }
        
        public int TypeGFXEId { get; set; }
        
        public bool IsSpecSum { get; set; }
        
        public bool IsNew { get; set; }
        
        public bool IsOnlyForSys { get; set; }
        
        public bool IsRpForbid { get; set; }
        
        public bool IsChildAdd { get; set; }
        
        public bool IsBedFee { get; set; }
        
        public bool IsOpsAdd { get; set; }
        
        public short LsfeeTurn { get; set; }
        
        public short LsAdviceType { get; set; }
        
        public int? LocationId { get; set; }
        
        public int? LISCode { get; set; }
        
        public string CoverPicture { get; set; }
        
        public string MemoPicture { get; set; }
        
        public string Memo { get; set; }
        
        public bool IsActive { get; set; }
        
        public string F1 { get; set; }
        
        public string F2 { get; set; }
        
        public string F3 { get; set; }
        
        public string F4 { get; set; }
        
        public short IconIndex { get; set; }
        
        public bool? IsInoculate { get; set; }
        
        public decimal? PriceHighLine { get; set; }
        
        public short? OrderBy { get; set; }
        
        public int? GroupSubId2 { get; set; }
        
        public DateTime? LastTime { get; set; }
        
        public decimal? PriceSub { get; set; }
        
        public int? CheckId { get; set; }
        
        public int? NurseId { get; set; }
        
        public int? CureId { get; set; }
        
        public int? DrugID { get; set; }
        
        public int? CopyId { get; set; }
        
        public int? MzUnitTotal { get; set; }
        
        public int? ZyUnitTotal { get; set; }
        
        public bool? IsMtDrug { get; set; }
        
        public string PackageSpec { get; set; }
        
        public bool IsCitySum { get; set; }
        
        public virtual ICollection<LmFood> Foods { get; set; }
    }
}

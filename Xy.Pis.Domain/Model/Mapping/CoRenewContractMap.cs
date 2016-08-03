using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoRenewContractMap : EntityTypeConfiguration<CoRenewContract>
    {
        public CoRenewContractMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CoRenewContract");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.BedYearTypeId).HasColumnName("BedYearTypeId");
            this.Property(t => t.AgreementBeginDate).HasColumnName("AgreementBeginDate");
            this.Property(t => t.AgreementEndDate).HasColumnName("AgreementEndDate");
            this.Property(t => t.IsFirst).HasColumnName("IsFirst");
            this.Property(t => t.NewBedYearTypeId).HasColumnName("NewBedYearTypeId");
            this.Property(t => t.NewAgreementBeginDate).HasColumnName("NewAgreementBeginDate");
            this.Property(t => t.NewAgreementEndDate).HasColumnName("NewAgreementEndDate");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
        }
    }
}

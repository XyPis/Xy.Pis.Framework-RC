using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InSubsidyMonthDetailMap : EntityTypeConfiguration<InSubsidyMonthDetail>
    {
        public InSubsidyMonthDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InSubsidyMonthDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SubsidyYear).HasColumnName("SubsidyYear");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.JanuarySubsidyId).HasColumnName("JanuarySubsidyId");
            this.Property(t => t.FebruarySubsidyId).HasColumnName("FebruarySubsidyId");
            this.Property(t => t.MarchSubsidyId).HasColumnName("MarchSubsidyId");
            this.Property(t => t.AprilSubsidyId).HasColumnName("AprilSubsidyId");
            this.Property(t => t.MaySubsidyId).HasColumnName("MaySubsidyId");
            this.Property(t => t.JuneSubsidyId).HasColumnName("JuneSubsidyId");
            this.Property(t => t.JulySubsidyId).HasColumnName("JulySubsidyId");
            this.Property(t => t.AugustSubsidyId).HasColumnName("AugustSubsidyId");
            this.Property(t => t.SeptemberSubsidyId).HasColumnName("SeptemberSubsidyId");
            this.Property(t => t.OctoberSubsidyId).HasColumnName("OctoberSubsidyId");
            this.Property(t => t.NovemberSubsidyId).HasColumnName("NovemberSubsidyId");
            this.Property(t => t.DecemberSubsidyId).HasColumnName("DecemberSubsidyId");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}

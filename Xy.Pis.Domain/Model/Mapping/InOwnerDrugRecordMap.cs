using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InOwnerDrugRecordMap : EntityTypeConfiguration<InOwnerDrugRecord>
    {
        public InOwnerDrugRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SpecDosage)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InOwnerDrugRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.SpecDosage).HasColumnName("SpecDosage");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.RemainTotality).HasColumnName("RemainTotality");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsPrinted).HasColumnName("IsPrinted");
            this.Property(t => t.IsStopSend).HasColumnName("IsStopSend");
            this.Property(t => t.StopSendTime).HasColumnName("StopSendTime");
            this.Property(t => t.StopSendOperID).HasColumnName("StopSendOperID");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.InOwnerDrugRecords)
                .HasForeignKey(d => d.FrequencyId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InOwnerDrugRecords)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InOwnerDrugRecords)
                .HasForeignKey(d => d.HospId);

        }
    }
}

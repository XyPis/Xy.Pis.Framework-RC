using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class HuAdjustDtlMap : EntityTypeConfiguration<HuAdjustDtl>
    {
        public HuAdjustDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuAdjustDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.ProfLoss).HasColumnName("ProfLoss");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuAdjustDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.HuAdjust)
                .WithMany(t => t.HuAdjustDtls)
                .HasForeignKey(d => d.BillId);
            this.HasRequired(t => t.HuStore)
                .WithMany(t => t.HuAdjustDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoDiscountApplyMap : EntityTypeConfiguration<CoDiscountApply>
    {
        public CoDiscountApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DiscountReason)
                .HasMaxLength(200);

            this.Property(t => t.ReturnReason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CoDiscountApply");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsDiscountType).HasColumnName("LsDiscountType");
            this.Property(t => t.DiscountRatio).HasColumnName("DiscountRatio");
            this.Property(t => t.DiscountReason).HasColumnName("DiscountReason");
            this.Property(t => t.IsSubmit).HasColumnName("IsSubmit");
            this.Property(t => t.ReturnReason).HasColumnName("ReturnReason");
            this.Property(t => t.DelFlag).HasColumnName("DelFlag");
            this.Property(t => t.ApplyID).HasColumnName("ApplyID");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.LsAuditStatus).HasColumnName("LsAuditStatus");
            this.Property(t => t.AuditId).HasColumnName("AuditId");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
            this.Property(t => t.BeginExecuteTime).HasColumnName("BeginExecuteTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.CoDiscountApplies)
                .HasForeignKey(d => d.AuditId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.CoDiscountApplies1)
                .HasForeignKey(d => d.ApplyID);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.CoDiscountApplies)
                .HasForeignKey(d => d.HospId);

        }
    }
}

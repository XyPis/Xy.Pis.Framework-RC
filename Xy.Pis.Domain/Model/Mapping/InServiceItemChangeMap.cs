using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InServiceItemChangeMap : EntityTypeConfiguration<InServiceItemChange>
    {
        public InServiceItemChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ChangeName)
                .HasMaxLength(250);

            this.Property(t => t.ChangeReason)
                .HasMaxLength(200);

            this.Property(t => t.ReturnReason)
                .HasMaxLength(500);

            this.Property(t => t.ApplyName)
                .HasMaxLength(250);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.CoPatientPrimeCostId)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("InServiceItemChange");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsChangeType).HasColumnName("LsChangeType");
            this.Property(t => t.ChangeId).HasColumnName("ChangeId");
            this.Property(t => t.ChangeItemId).HasColumnName("ChangeItemId");
            this.Property(t => t.ChangeAmount).HasColumnName("ChangeAmount");
            this.Property(t => t.ChangeName).HasColumnName("ChangeName");
            this.Property(t => t.ChangeReason).HasColumnName("ChangeReason");
            this.Property(t => t.IsSubmit).HasColumnName("IsSubmit");
            this.Property(t => t.ReturnReason).HasColumnName("ReturnReason");
            this.Property(t => t.DelFlag).HasColumnName("DelFlag");
            this.Property(t => t.ApplyId).HasColumnName("ApplyId");
            this.Property(t => t.ApplyName).HasColumnName("ApplyName");
            this.Property(t => t.ApplyItemId).HasColumnName("ApplyItemId");
            this.Property(t => t.ApplyAmount).HasColumnName("ApplyAmount");
            this.Property(t => t.ApplyOperId).HasColumnName("ApplyOperId");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.LsAuditStatus).HasColumnName("LsAuditStatus");
            this.Property(t => t.AuditOperId).HasColumnName("AuditOperId");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
            this.Property(t => t.BeginExecuteTime).HasColumnName("BeginExecuteTime");
            this.Property(t => t.IsExecute).HasColumnName("IsExecute");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.IsSubmitFee).HasColumnName("IsSubmitFee");
            this.Property(t => t.CoPatientPrimeCostId).HasColumnName("CoPatientPrimeCostId");
        }
    }
}

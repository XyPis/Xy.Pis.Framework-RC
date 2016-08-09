using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InDrawMoneyAuthMap : EntityTypeConfiguration<InDrawMoneyAuth>
    {
        public InDrawMoneyAuthMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DrawStepName)
                .HasMaxLength(50);

            this.Property(t => t.ApprovalResult)
                .HasMaxLength(500);

            this.Property(t => t.ApprovalComment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InDrawMoneyAuth");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DrawMoneyId).HasColumnName("DrawMoneyId");
            this.Property(t => t.DrawStepName).HasColumnName("DrawStepName");
            this.Property(t => t.UserLevelId).HasColumnName("UserLevelId");
            this.Property(t => t.ApprovalOperId).HasColumnName("ApprovalOperId");
            this.Property(t => t.LsApprovalStatus).HasColumnName("LsApprovalStatus");
            this.Property(t => t.ApprovalTime).HasColumnName("ApprovalTime");
            this.Property(t => t.ApprovalResult).HasColumnName("ApprovalResult");
            this.Property(t => t.ApprovalComment).HasColumnName("ApprovalComment");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}

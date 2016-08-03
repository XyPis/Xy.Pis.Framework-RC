using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InRepaymentMap : EntityTypeConfiguration<InRepayment>
    {
        public InRepaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InRepayment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DrawMoneyId).HasColumnName("DrawMoneyId");
            this.Property(t => t.RePayTime).HasColumnName("RePayTime");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ModifyOperId).HasColumnName("ModifyOperId");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
        }
    }
}

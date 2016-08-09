using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InDrawMoneyMap : EntityTypeConfiguration<InDrawMoney>
    {
        public InDrawMoneyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Purpose)
                .HasMaxLength(500);

            this.Property(t => t.Unit)
                .HasMaxLength(500);

            this.Property(t => t.BackComment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InDrawMoney");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DrawOperId).HasColumnName("DrawOperId");
            this.Property(t => t.DrawOperTime).HasColumnName("DrawOperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.BackComment).HasColumnName("BackComment");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.ModifyOperId).HasColumnName("ModifyOperId");
            this.Property(t => t.ModifyOperTime).HasColumnName("ModifyOperTime");
        }
    }
}

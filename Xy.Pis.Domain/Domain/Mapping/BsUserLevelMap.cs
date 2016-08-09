using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsUserLevelMap : EntityTypeConfiguration<BsUserLevel>
    {
        public BsUserLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(300);

            this.Property(t => t.WbCode)
                .HasMaxLength(15);

            this.Property(t => t.PyCode)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("BsUserLevel");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsHealthEduRecMap : EntityTypeConfiguration<BsHealthEduRec>
    {
        public BsHealthEduRecMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Rmark)
                .HasMaxLength(100);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsHealthEduRec");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.HealthEduRec).HasColumnName("HealthEduRec");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Rmark).HasColumnName("Rmark");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IdleFlag).HasColumnName("IdleFlag");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}

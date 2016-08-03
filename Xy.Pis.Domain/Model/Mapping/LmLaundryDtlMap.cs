using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LmLaundryDtlMap : EntityTypeConfiguration<LmLaundryDtl>
    {
        public LmLaundryDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LmLaundryDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LaundryId).HasColumnName("LaundryId");
            this.Property(t => t.ClothingId).HasColumnName("ClothingId");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.BackTotality).HasColumnName("BackTotality");
            this.Property(t => t.IsAlso).HasColumnName("IsAlso");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasOptional(t => t.BsClothing)
                .WithMany(t => t.LmLaundryDtls)
                .HasForeignKey(d => d.ClothingId);
            this.HasOptional(t => t.LmLaundry)
                .WithMany(t => t.LmLaundryDtls)
                .HasForeignKey(d => d.LaundryId);

        }
    }
}

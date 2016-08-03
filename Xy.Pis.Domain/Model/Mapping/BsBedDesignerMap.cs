using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsBedDesignerMap : EntityTypeConfiguration<BsBedDesigner>
    {
        public BsBedDesignerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BsBedDesigner");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.FloorNum).HasColumnName("FloorNum");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.LocationX).HasColumnName("LocationX");
            this.Property(t => t.LocationY).HasColumnName("LocationY");
            this.Property(t => t.SizeWidth).HasColumnName("SizeWidth");
            this.Property(t => t.SizeHeight).HasColumnName("SizeHeight");
            this.Property(t => t.IsShowBorder).HasColumnName("IsShowBorder");
            this.Property(t => t.IsTopOrBottom).HasColumnName("IsTopOrBottom");
        }
    }
}

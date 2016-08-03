using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsDormitoryDesignerDtlMap : EntityTypeConfiguration<BsDormitoryDesignerDtl>
    {
        public BsDormitoryDesignerDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsDormitoryDesignerDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DesignerID).HasColumnName("DesignerID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}

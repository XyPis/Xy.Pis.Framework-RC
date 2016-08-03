using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class inHyDropowerDetailMap : EntityTypeConfiguration<inHyDropowerDetail>
    {
        public inHyDropowerDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("inHyDropowerDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HyDropowerID).HasColumnName("HyDropowerID");
            this.Property(t => t.LshydropowerType).HasColumnName("LshydropowerType");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ElectricNumbers).HasColumnName("ElectricNumbers");

            // Relationships
            this.HasRequired(t => t.InHydropowerRecord)
                .WithMany(t => t.inHyDropowerDetails)
                .HasForeignKey(d => d.HyDropowerID);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsPatPhotoMap : EntityTypeConfiguration<BsPatPhoto>
    {
        public BsPatPhotoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BsPatPhoto");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.Image).HasColumnName("Image");

            // Relationships
            this.HasOptional(t => t.BsPatient)
                .WithMany(t => t.BsPatPhotoes)
                .HasForeignKey(d => d.PatId);

        }
    }
}

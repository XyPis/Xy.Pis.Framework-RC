using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InNumberOfDinerMap : EntityTypeConfiguration<InNumberOfDiner>
    {
        public InNumberOfDinerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InNumberOfDiners");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NumOfDiners).HasColumnName("NumOfDiners");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.EatingTime).HasColumnName("EatingTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.SignTime).HasColumnName("SignTime");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.InNumberOfDiners)
                .HasForeignKey(d => d.LocationId);

        }
    }
}

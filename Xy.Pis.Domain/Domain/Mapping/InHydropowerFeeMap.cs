using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHydropowerFeeMap : EntityTypeConfiguration<InHydropowerFee>
    {
        public InHydropowerFeeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HappenTime)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InHydropowerFee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.BedID).HasColumnName("BedID");
            this.Property(t => t.WaterFee).HasColumnName("WaterFee");
            this.Property(t => t.ElectricFee).HasColumnName("ElectricFee");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.IsCharge).HasColumnName("IsCharge");
            this.Property(t => t.InHydropowerID).HasColumnName("InHydropowerID");
        }
    }
}

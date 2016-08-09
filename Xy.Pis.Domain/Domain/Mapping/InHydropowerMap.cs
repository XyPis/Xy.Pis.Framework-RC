using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHydropowerMap : EntityTypeConfiguration<InHydropower>
    {
        public InHydropowerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RoomNum)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HappenTime)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InHydropower");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoomNum).HasColumnName("RoomNum");
            this.Property(t => t.FloorNum).HasColumnName("FloorNum");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.LastTimeWaterFee).HasColumnName("LastTimeWaterFee");
            this.Property(t => t.LastTimeElectricFee).HasColumnName("LastTimeElectricFee");
            this.Property(t => t.WaterFee).HasColumnName("WaterFee");
            this.Property(t => t.ElectricFee).HasColumnName("ElectricFee");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}

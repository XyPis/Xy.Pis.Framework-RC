using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoYearRoomFeeMap : EntityTypeConfiguration<CoYearRoomFee>
    {
        public CoYearRoomFeeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CoYearRoomFee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BedRoomTypeId).HasColumnName("BedRoomTypeId");
            this.Property(t => t.BedYearTypeId).HasColumnName("BedYearTypeId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.BedFloorId).HasColumnName("BedFloorId");
        }
    }
}

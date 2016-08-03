using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwMonthlyCostStandardMap : EntityTypeConfiguration<VwMonthlyCostStandard>
    {
        public VwMonthlyCostStandardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PriceIn, t.ExpenseType, t.BackDays, t.IsActive, t.BedRoomTypeId, t.BedYearTypeId, t.BedFloorId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExpenseType)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.BackDays)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BedYearTypeName)
                .HasMaxLength(50);

            this.Property(t => t.BedRoomTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BedYearTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BedFloorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwMonthlyCostStandard");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.ExpenseType).HasColumnName("ExpenseType");
            this.Property(t => t.BackDays).HasColumnName("BackDays");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.BedYearTypeName).HasColumnName("BedYearTypeName");
            this.Property(t => t.BedRoomTypeId).HasColumnName("BedRoomTypeId");
            this.Property(t => t.BedYearTypeId).HasColumnName("BedYearTypeId");
            this.Property(t => t.BedFloorId).HasColumnName("BedFloorId");
        }
    }
}

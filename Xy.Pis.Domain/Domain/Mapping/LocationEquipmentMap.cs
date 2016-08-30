using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LocationEquipmentMap : EntityTypeConfiguration<LocationEquipment>
    {
        public LocationEquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);
             
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .HasMaxLength(100);

            this.Property(t => t.UseLocation)
                .HasMaxLength(100);

            this.Property(t => t.StorageLocation)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HasUsedTime)
                .HasMaxLength(50);

            this.Property(t => t.VoucherNo)
                .HasMaxLength(50);

            this.Property(t => t.SourcesOfFunds)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("LocationEquipments");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.UseLocation).HasColumnName("UseLocation");
            this.Property(t => t.ManageManId).HasColumnName("ManageManId");
            this.Property(t => t.StorageLocation).HasColumnName("StorageLocation");
            this.Property(t => t.BuyInDate).HasColumnName("BuyInDate");
            this.Property(t => t.Num).HasColumnName("Num");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.HasUsedTime).HasColumnName("HasUsedTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.SourcesOfFunds).HasColumnName("SourcesOfFunds");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}

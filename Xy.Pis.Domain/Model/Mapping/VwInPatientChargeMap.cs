using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwInPatientChargeMap : EntityTypeConfiguration<VwInPatientCharge>
    {
        public VwInPatientChargeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.InPatNo, t.Sex, t.Prepaid, t.Unliquidated });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BedAddress)
                .HasMaxLength(100);

            this.Property(t => t.Prepaid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unliquidated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwInPatientCharge");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BedAddress).HasColumnName("BedAddress");
            this.Property(t => t.Prepaid).HasColumnName("Prepaid");
            this.Property(t => t.Unliquidated).HasColumnName("Unliquidated");
        }
    }
}

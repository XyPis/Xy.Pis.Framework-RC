using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwLmLaundryMap : EntityTypeConfiguration<VwLmLaundry>
    {
        public VwLmLaundryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.Name, t.Sex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.BedAdress)
                .HasMaxLength(100);

            this.Property(t => t.DeliveryOperName)
                .HasMaxLength(30);

            this.Property(t => t.ReceivingOperName)
                .HasMaxLength(30);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwLmLaundry");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BedAdress).HasColumnName("BedAdress");
            this.Property(t => t.DeliveryOperId).HasColumnName("DeliveryOperId");
            this.Property(t => t.DeliveryOperName).HasColumnName("DeliveryOperName");
            this.Property(t => t.DeliveryTime).HasColumnName("DeliveryTime");
            this.Property(t => t.ReceivingOperId).HasColumnName("ReceivingOperId");
            this.Property(t => t.ReceivingOperName).HasColumnName("ReceivingOperName");
            this.Property(t => t.ReceivingTime).HasColumnName("ReceivingTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LmLaundryMap : EntityTypeConfiguration<LmLaundry>
    {
        public LmLaundryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("LmLaundry");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.DeliveryOperId).HasColumnName("DeliveryOperId");
            this.Property(t => t.DeliveryTime).HasColumnName("DeliveryTime");
            this.Property(t => t.ReceivingOperId).HasColumnName("ReceivingOperId");
            this.Property(t => t.ReceivingTime).HasColumnName("ReceivingTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.LmLaundries)
                .HasForeignKey(d => d.DeliveryOperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.LmLaundries1)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.BsUser2)
                .WithMany(t => t.LmLaundries2)
                .HasForeignKey(d => d.ReceivingOperId);

        }
    }
}

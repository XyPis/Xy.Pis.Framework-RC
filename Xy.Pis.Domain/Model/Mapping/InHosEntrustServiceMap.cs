using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHosEntrustServiceMap : EntityTypeConfiguration<InHosEntrustService>
    {
        public InHosEntrustServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InHosEntrustService");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.EntrustItemId).HasColumnName("EntrustItemId");
            this.Property(t => t.HosRenewId).HasColumnName("HosRenewId");

            // Relationships
            this.HasOptional(t => t.BsEntrustItem)
                .WithMany(t => t.InHosEntrustServices)
                .HasForeignKey(d => d.EntrustItemId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.InHosEntrustServices)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InHosInfoRenew)
                .WithMany(t => t.InHosEntrustServices)
                .HasForeignKey(d => d.HosRenewId);

        }
    }
}

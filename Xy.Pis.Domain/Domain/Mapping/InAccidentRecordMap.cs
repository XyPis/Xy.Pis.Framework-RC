using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InAccidentRecordMap : EntityTypeConfiguration<InAccidentRecord>
    {
        public InAccidentRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HappenDate)
                .HasMaxLength(20);

            this.Property(t => t.HappenTime)
                .HasMaxLength(20);

            this.Property(t => t.Reason)
                .HasMaxLength(200);

            this.Property(t => t.HandleResults)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("InAccidentRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.HappenDate).HasColumnName("HappenDate");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.DutyOperID).HasColumnName("DutyOperID");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.HandleResults).HasColumnName("HandleResults");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
        }
    }
}

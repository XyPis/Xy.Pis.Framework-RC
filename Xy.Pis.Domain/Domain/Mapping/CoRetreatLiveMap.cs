using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoRetreatLiveMap : EntityTypeConfiguration<CoRetreatLive>
    {
        public CoRetreatLiveMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckInPlace)
                .HasMaxLength(150);

            this.Property(t => t.Memo)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CoRetreatLive");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.CheckInPlace).HasColumnName("CheckInPlace");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ExecuteTime).HasColumnName("ExecuteTime");
            this.Property(t => t.LsLive).HasColumnName("LsLive");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.AuditOperId).HasColumnName("AuditOperId");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
        }
    }
}

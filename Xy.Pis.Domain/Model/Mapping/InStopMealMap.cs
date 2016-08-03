using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InStopMealMap : EntityTypeConfiguration<InStopMeal>
    {
        public InStopMealMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckInArea)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("InStopMeal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.CheckInArea).HasColumnName("CheckInArea");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.AuditOperID).HasColumnName("AuditOperID");
            this.Property(t => t.AuditOperTime).HasColumnName("AuditOperTime");
        }
    }
}

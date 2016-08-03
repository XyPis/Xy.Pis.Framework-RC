using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InMonthFeeBillMap : EntityTypeConfiguration<InMonthFeeBill>
    {
        public InMonthFeeBillMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InMonthFeeBill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedFloorId).HasColumnName("BedFloorId");
            this.Property(t => t.FeeMonth).HasColumnName("FeeMonth");
            this.Property(t => t.FeeDays).HasColumnName("FeeDays");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.PayId).HasColumnName("PayId");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.AuditId).HasColumnName("AuditId");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
        }
    }
}

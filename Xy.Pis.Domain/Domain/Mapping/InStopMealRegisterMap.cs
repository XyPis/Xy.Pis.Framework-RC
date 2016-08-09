using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InStopMealRegisterMap : EntityTypeConfiguration<InStopMealRegister>
    {
        public InStopMealRegisterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InStopMealRegister");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.OrderMealsCount).HasColumnName("OrderMealsCount");
            this.Property(t => t.StopMealCount).HasColumnName("StopMealCount");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.AuditID).HasColumnName("AuditID");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class AdditionalMealMap : EntityTypeConfiguration<AdditionalMeal>
    {
        public AdditionalMealMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("AdditionalMeal");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OrderStatus).HasColumnName("OrderStatus");
            this.Property(t => t.Auditor).HasColumnName("Auditor");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.Canceller).HasColumnName("Canceller");
            this.Property(t => t.CancellationDate).HasColumnName("CancellationDate");
            this.Property(t => t.AddUser).HasColumnName("AddUser");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.UpdtUser).HasColumnName("UpdtUser");
            this.Property(t => t.UpdtDate).HasColumnName("UpdtDate");

            // Relationships
            this.HasRequired(t => t.InHosInfo)
           .WithMany(t => t.AdditionalMeals)
           .HasForeignKey(d => d.HospId);
        }
    }
}

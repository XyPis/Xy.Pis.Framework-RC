using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LmWorkRepairMap : EntityTypeConfiguration<LmWorkRepair>
    {
        public LmWorkRepairMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Position)
                .HasMaxLength(200);

            this.Property(t => t.Memo)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LmWorkRepair");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.RepairLocationId).HasColumnName("RepairLocationId");
            this.Property(t => t.CompletionBeginTime).HasColumnName("CompletionBeginTime");
            this.Property(t => t.CompletionEndTime).HasColumnName("CompletionEndTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");

            this.HasOptional(t => t.ReponsiblityLoc)
                .WithMany(t => t.EngineeringMaintenances)
                .HasForeignKey(d => d.RepairLocationId);          
        }
    }
}

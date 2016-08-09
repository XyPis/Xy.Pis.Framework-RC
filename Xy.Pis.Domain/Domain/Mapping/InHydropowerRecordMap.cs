using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHydropowerRecordMap : EntityTypeConfiguration<InHydropowerRecord>
    {
        public InHydropowerRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RoomBedNum)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InHydropowerRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.YearMonth).HasColumnName("YearMonth");
            this.Property(t => t.FloorNumId).HasColumnName("FloorNumId");
            this.Property(t => t.RoomBedNum).HasColumnName("RoomBedNum");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LastMonthElectricity).HasColumnName("LastMonthElectricity");
            this.Property(t => t.CurrentMonthElectricity).HasColumnName("CurrentMonthElectricity");
            this.Property(t => t.ElectricMothNumbers).HasColumnName("ElectricMothNumbers");
            this.Property(t => t.ContinuousLeaveDays).HasColumnName("ContinuousLeaveDays");
            this.Property(t => t.MealDays).HasColumnName("MealDays");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.AuditID).HasColumnName("AuditID");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
        }
    }
}

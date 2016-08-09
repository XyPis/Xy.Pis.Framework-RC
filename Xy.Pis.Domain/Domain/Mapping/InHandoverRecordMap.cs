using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHandoverRecordMap : EntityTypeConfiguration<InHandoverRecord>
    {
        public InHandoverRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HandoverRecord)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("InHandoverRecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ShiftOperID).HasColumnName("ShiftOperID");
            this.Property(t => t.SucceedID).HasColumnName("SucceedID");
            this.Property(t => t.FloorNum).HasColumnName("FloorNum");
            this.Property(t => t.ShiftTime).HasColumnName("ShiftTime");
            this.Property(t => t.YardNum).HasColumnName("YardNum");
            this.Property(t => t.OutYardNum).HasColumnName("OutYardNum");
            this.Property(t => t.TurnOutNum).HasColumnName("TurnOutNum");
            this.Property(t => t.TurnInNum).HasColumnName("TurnInNum");
            this.Property(t => t.HeavyNum).HasColumnName("HeavyNum");
            this.Property(t => t.DangerNum).HasColumnName("DangerNum");
            this.Property(t => t.LeaveNum).HasColumnName("LeaveNum");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.HandoverRecord).HasColumnName("HandoverRecord");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
        }
    }
}

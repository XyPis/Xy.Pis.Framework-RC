using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InOutNoteMap : EntityTypeConfiguration<InOutNote>
    {
        public InOutNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckInPlace)
                .HasMaxLength(100);

            this.Property(t => t.LeaveReason)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InOutNotes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.CheckInPlace).HasColumnName("CheckInPlace");
            this.Property(t => t.LeaveTime).HasColumnName("LeaveTime");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.LeaveReason).HasColumnName("LeaveReason");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
        }
    }
}

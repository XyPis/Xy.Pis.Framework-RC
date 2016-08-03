using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InOwnerDrugLogMap : EntityTypeConfiguration<InOwnerDrugLog>
    {
        public InOwnerDrugLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InOwnerDrugLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecordId).HasColumnName("RecordId");
            this.Property(t => t.LsOwnerDrugOperType).HasColumnName("LsOwnerDrugOperType");
            this.Property(t => t.OperDosage).HasColumnName("OperDosage");
            this.Property(t => t.OperTimes).HasColumnName("OperTimes");
            this.Property(t => t.OperTotality).HasColumnName("OperTotality");
            this.Property(t => t.OperBeforeTotality).HasColumnName("OperBeforeTotality");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.ExecuteStopTime).HasColumnName("ExecuteStopTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}

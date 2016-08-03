using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InWatchBedMap : EntityTypeConfiguration<InWatchBed>
    {
        public InWatchBedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InWatchBed");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LsState).HasColumnName("LsState");
        }
    }
}

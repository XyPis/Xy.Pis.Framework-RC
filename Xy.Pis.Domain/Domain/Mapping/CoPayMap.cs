using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoPayMap : EntityTypeConfiguration<CoPay>
    {
        public CoPayMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CoPay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PayWayId).HasColumnName("PayWayId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.SerialNum).HasColumnName("SerialNum");
        }
    }
}

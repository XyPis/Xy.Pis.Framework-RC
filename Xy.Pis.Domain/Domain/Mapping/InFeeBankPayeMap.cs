using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InFeeBankPayeMap : EntityTypeConfiguration<InFeeBankPaye>
    {
        public InFeeBankPayeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BankAccount)
                .IsRequired()
                .HasMaxLength(22);

            this.Property(t => t.Consignor)
                .HasMaxLength(16);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InFeeBankPaye");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospID).HasColumnName("HospID");
            this.Property(t => t.PayWayId).HasColumnName("PayWayId");
            this.Property(t => t.BankAccount).HasColumnName("BankAccount");
            this.Property(t => t.Consignor).HasColumnName("Consignor");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}

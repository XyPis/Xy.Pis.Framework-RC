using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoPatientPrimeCostMainMap : EntityTypeConfiguration<CoPatientPrimeCostMain>
    {
        public CoPatientPrimeCostMainMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InvoNo)
                .HasMaxLength(20);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(100);

            this.Property(t => t.DepositBillNo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CoPatientPrimeCostMain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.Deposit).HasColumnName("Deposit");
            this.Property(t => t.Complement).HasColumnName("Complement");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.CheckOperID).HasColumnName("CheckOperID");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.DepositBillNo).HasColumnName("DepositBillNo");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwCoPatientPrimeCostMainMap : EntityTypeConfiguration<VwCoPatientPrimeCostMain>
    {
        public VwCoPatientPrimeCostMainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.Name, t.NTime, t.HospId, t.AmountPay });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvoNo)
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .HasMaxLength(2);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmountPay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CancelMemo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VwCoPatientPrimeCostMain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelOperID).HasColumnName("CancelOperID");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
            this.Property(t => t.CancelMemo).HasColumnName("CancelMemo");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.CheckOperID).HasColumnName("CheckOperID");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
        }
    }
}

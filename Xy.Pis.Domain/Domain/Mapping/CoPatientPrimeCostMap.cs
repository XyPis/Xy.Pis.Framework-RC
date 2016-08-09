using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoPatientPrimeCostMap : EntityTypeConfiguration<CoPatientPrimeCost>
    {
        public CoPatientPrimeCostMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CoPatientPrimeCost");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HosRenewId).HasColumnName("HosRenewId");
            this.Property(t => t.LsPrimeType).HasColumnName("LsPrimeType");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.AddRatio).HasColumnName("AddRatio");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.AmountBack).HasColumnName("AmountBack");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsCharge).HasColumnName("IsCharge");
            this.Property(t => t.ChargeOperId).HasColumnName("ChargeOperId");
            this.Property(t => t.ChargeOperTime).HasColumnName("ChargeOperTime");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelId).HasColumnName("CancelId");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.CoPatientPrimeCostMainID).HasColumnName("CoPatientPrimeCostMainID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.LsSource).HasColumnName("LsSource");
            this.Property(t => t.SourceId).HasColumnName("SourceId");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.CoPatientPrimeCosts)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.CoPatientPrimeCosts)
                .HasForeignKey(d => d.OperID);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.CoPatientPrimeCosts1)
                .HasForeignKey(d => d.CancelId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.CoPatientPrimeCosts)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InHosInfoRenew)
                .WithMany(t => t.CoPatientPrimeCosts)
                .HasForeignKey(d => d.HosRenewId);

        }
    }
}

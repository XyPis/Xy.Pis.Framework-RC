using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoPatientFixedCostMap : EntityTypeConfiguration<CoPatientFixedCost>
    {
        public CoPatientFixedCostMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CoPatientFixedCost");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsItemType).HasColumnName("LsItemType");
            this.Property(t => t.LsMonthlyCharged).HasColumnName("LsMonthlyCharged");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.AddRatio).HasColumnName("AddRatio");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LastChargeOperId).HasColumnName("LastChargeOperId");
            this.Property(t => t.LastChargeOperTime).HasColumnName("LastChargeOperTime");
            this.Property(t => t.IsStopCharge).HasColumnName("IsStopCharge");
            this.Property(t => t.StopChargeOperID).HasColumnName("StopChargeOperID");
            this.Property(t => t.StopChargeOperTime).HasColumnName("StopChargeOperTime");
            this.Property(t => t.StopChargeTime).HasColumnName("StopChargeTime");
            this.Property(t => t.LastChangeItemTime).HasColumnName("LastChangeItemTime");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.CoPatientFixedCosts)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.CoPatientFixedCosts)
                .HasForeignKey(d => d.HospId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class RmStockDtlMap : EntityTypeConfiguration<RmStockDtl>
    {
        public RmStockDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.VoucherNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PassNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RmStockDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.PassNo).HasColumnName("PassNo");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmStockDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsManufacturer)
                .WithMany(t => t.RmStockDtls)
                .HasForeignKey(d => d.ManuId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmStockDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.RmStock)
                .WithMany(t => t.RmStockDtls)
                .HasForeignKey(d => d.BillId);

        }
    }
}

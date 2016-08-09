using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class RmStockReqdtlMap : EntityTypeConfiguration<RmStockReqdtl>
    {
        public RmStockReqdtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RmStockReqdtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmStockReqdtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmStockReqdtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.RmStockReq)
                .WithMany(t => t.RmStockReqdtls)
                .HasForeignKey(d => d.BillId);

        }
    }
}

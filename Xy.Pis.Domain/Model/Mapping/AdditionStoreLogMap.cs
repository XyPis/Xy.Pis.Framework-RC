using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class AdditionStoreLogMap : EntityTypeConfiguration<AdditionStoreLog>
    {
        public AdditionStoreLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdditionStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");

            // Relationships
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.AdditionStoreLogs)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.AdditionStoreLogs)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.AdditionStoreLogs)
                .HasForeignKey(d => d.UnitId);

        }
    }
}

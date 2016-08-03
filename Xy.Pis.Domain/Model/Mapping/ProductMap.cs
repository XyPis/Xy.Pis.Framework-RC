using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}

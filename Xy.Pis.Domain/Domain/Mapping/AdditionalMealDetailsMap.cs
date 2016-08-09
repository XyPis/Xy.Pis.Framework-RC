using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class AdditionalMealDetailsMap : EntityTypeConfiguration<AdditionalMealDetails>
    {
        public AdditionalMealDetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AdditionalMealType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("AdditionalMealDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.AdditionalMealId).HasColumnName("AdditionalMealId");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.AdditionalMealType).HasColumnName("AdditionalMealType");

            // Relationships
            this.HasRequired(t => t.AdditionalMeal)
                .WithMany(t => t.Details)
                .HasForeignKey(d => d.AdditionalMealId);

            this.HasRequired(t => t.Food)
                .WithMany(t => t.AdditionalMealDetails)
                .HasForeignKey(d => d.FoodId);           
        }
    }
}

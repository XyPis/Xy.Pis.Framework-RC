using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class lmDayMenuFoodMap : EntityTypeConfiguration<LmDayMenuFood>
    {
        public lmDayMenuFoodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("lmDayMenuFood");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.dmId).HasColumnName("dmId");
            this.Property(t => t.fId).HasColumnName("fId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.lsClass).HasColumnName("lsClass");

            // Relationships
            this.HasOptional(t => t.lmDayMenu)
                .WithMany(t => t.lmDayMenuFoods)
                .HasForeignKey(d => d.dmId);
            this.HasOptional(t => t.lmFood)
                .WithMany(t => t.lmDayMenuFoods)
                .HasForeignKey(d => d.fId);

        }
    }
}

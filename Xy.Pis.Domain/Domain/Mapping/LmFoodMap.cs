using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LmFoodMap : EntityTypeConfiguration<LmFood>
    {
        public LmFoodMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsAction)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Effect)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.TimeFrame)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LmFood");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.LsAction).HasColumnName("lsAction");
            this.Property(t => t.Effect).HasColumnName("Effect");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.TimeFrame).HasColumnName("TimeFrame");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.ItemId).HasColumnName("ItemId");

            this.HasRequired(t => t.BsItem)
               .WithMany(t => t.Foods)
               .HasForeignKey(d => d.ItemId);
        }
    }
}

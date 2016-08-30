using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class LmWeekFoodMap : EntityTypeConfiguration<LmWeekFood>
    {
        public LmWeekFoodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LsData)
                .IsRequired();

            this.Property(t => t.PyCode)
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("lmWeekFood");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LsData).HasColumnName("lsData");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LastModifyTime).HasColumnName("LastModifyTime");
            this.Property(t => t.LastModify).HasColumnName("LastModify");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
        }
    }
}

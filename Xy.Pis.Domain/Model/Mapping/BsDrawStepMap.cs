using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsDrawStepMap : EntityTypeConfiguration<BsDrawStep>
    {
        public BsDrawStepMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(15);

            this.Property(t => t.PyCode)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("BsDrawStep");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FunctionListId).HasColumnName("FunctionListId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.UserLevelId).HasColumnName("UserLevelId");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
        }
    }
}

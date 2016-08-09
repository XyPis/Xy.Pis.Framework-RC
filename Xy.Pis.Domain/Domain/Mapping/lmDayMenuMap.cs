using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class lmDayMenuMap : EntityTypeConfiguration<LmDayMenu>
    {
        public lmDayMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("lmDayMenu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.wfID).HasColumnName("wfID");
            this.Property(t => t.lsDate).HasColumnName("lsDate");

            // Relationships
            this.HasOptional(t => t.lmWeekFood)
                .WithMany(t => t.lmDayMenus)
                .HasForeignKey(d => d.wfID);

        }
    }
}

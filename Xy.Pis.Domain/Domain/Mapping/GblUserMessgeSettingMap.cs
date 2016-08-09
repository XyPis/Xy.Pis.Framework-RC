using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class GblUserMessgeSettingMap : EntityTypeConfiguration<GblUserMessgeSetting>
    {
        public GblUserMessgeSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GblUserMessgeSetting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.LsMessageType).HasColumnName("LsMessageType");
            this.Property(t => t.IntervalMinute).HasColumnName("IntervalMinute");
        }
    }
}

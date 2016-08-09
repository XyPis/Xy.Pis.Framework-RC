using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InLinkManMap : EntityTypeConfiguration<InLinkMan>
    {
        public InLinkManMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TempLinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.TempLinkmanIdCard)
                .HasMaxLength(20);

            this.Property(t => t.TempLinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.TempLinkmanFamilyAddress)
                .HasMaxLength(100);

            this.Property(t => t.TempLinkmanFamilyPhone)
                .HasMaxLength(15);

            this.Property(t => t.TempLinkmanPhone)
                .HasMaxLength(15);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("InLinkMan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TempLinkmanName).HasColumnName("TempLinkmanName");
            this.Property(t => t.TempRelationId).HasColumnName("TempRelationId");
            this.Property(t => t.TempLinkmanIdCard).HasColumnName("TempLinkmanIdCard");
            this.Property(t => t.TempLinkManWorkUnit).HasColumnName("TempLinkManWorkUnit");
            this.Property(t => t.TempLinkmanFamilyAddress).HasColumnName("TempLinkmanFamilyAddress");
            this.Property(t => t.TempLinkmanFamilyPhone).HasColumnName("TempLinkmanFamilyPhone");
            this.Property(t => t.TempLinkmanPhone).HasColumnName("TempLinkmanPhone");
            this.Property(t => t.HospId).HasColumnName("HospId");
        }
    }
}

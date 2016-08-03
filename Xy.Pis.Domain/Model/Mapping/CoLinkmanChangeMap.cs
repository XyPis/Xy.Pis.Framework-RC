using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoLinkmanChangeMap : EntityTypeConfiguration<CoLinkmanChange>
    {
        public CoLinkmanChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.LinkmanIdCard)
                .HasMaxLength(50);

            this.Property(t => t.LinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanUnitAddress)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanFamilyAddress)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanFamilyPhone)
                .HasMaxLength(15);

            this.Property(t => t.LinkmanPhone)
                .HasMaxLength(15);

            this.Property(t => t.Memo)
                .HasMaxLength(150);

            this.Property(t => t.LinkmanNameBefore)
                .HasMaxLength(20);

            this.Property(t => t.LinkmanIdCardBefore)
                .HasMaxLength(50);

            this.Property(t => t.LinkManWorkUnitBefore)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanUnitAddressBefore)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanFamilyAddressBefore)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanFamilyPhoneBefore)
                .HasMaxLength(15);

            this.Property(t => t.LinkmanPhoneBefore)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("CoLinkmanChange");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsType).HasColumnName("LsType");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.LinkmanIdCard).HasColumnName("LinkmanIdCard");
            this.Property(t => t.LinkManWorkUnit).HasColumnName("LinkManWorkUnit");
            this.Property(t => t.LinkmanUnitAddress).HasColumnName("LinkmanUnitAddress");
            this.Property(t => t.LinkmanFamilyAddress).HasColumnName("LinkmanFamilyAddress");
            this.Property(t => t.LinkmanFamilyPhone).HasColumnName("LinkmanFamilyPhone");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsAudit).HasColumnName("IsAudit");
            this.Property(t => t.AuditOperId).HasColumnName("AuditOperId");
            this.Property(t => t.AuditTime).HasColumnName("AuditTime");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LinkmanNameBefore).HasColumnName("LinkmanNameBefore");
            this.Property(t => t.RelationIdBefore).HasColumnName("RelationIdBefore");
            this.Property(t => t.LinkmanIdCardBefore).HasColumnName("LinkmanIdCardBefore");
            this.Property(t => t.LinkManWorkUnitBefore).HasColumnName("LinkManWorkUnitBefore");
            this.Property(t => t.LinkmanUnitAddressBefore).HasColumnName("LinkmanUnitAddressBefore");
            this.Property(t => t.LinkmanFamilyAddressBefore).HasColumnName("LinkmanFamilyAddressBefore");
            this.Property(t => t.LinkmanFamilyPhoneBefore).HasColumnName("LinkmanFamilyPhoneBefore");
            this.Property(t => t.LinkmanPhoneBefore).HasColumnName("LinkmanPhoneBefore");
            this.Property(t => t.LsChangeType).HasColumnName("LsChangeType");
            this.Property(t => t.MealOperId).HasColumnName("MealOperId");
            this.Property(t => t.MealTime).HasColumnName("MealTime");
        }
    }
}

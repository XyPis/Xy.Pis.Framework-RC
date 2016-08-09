using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Nurse_002_EvaluationItemMap : EntityTypeConfiguration<Nurse_002_EvaluationItem>
    {
        public Nurse_002_EvaluationItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.EvaluationTypeID, t.EvaluationItemName, t.ItemMaxScore });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EvaluationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EvaluationItemName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ModifiedID)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Nurse_002_EvaluationItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.EvaluationTypeID).HasColumnName("EvaluationTypeID");
            this.Property(t => t.EvaluationItemID).HasColumnName("EvaluationItemID");
            this.Property(t => t.EvaluationItemName).HasColumnName("EvaluationItemName");
            this.Property(t => t.ItemMaxScore).HasColumnName("ItemMaxScore");
            this.Property(t => t.DelFlag).HasColumnName("DelFlag");
            this.Property(t => t.ModifiedID).HasColumnName("ModifiedID");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}

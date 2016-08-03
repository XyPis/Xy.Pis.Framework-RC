using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Nurse_004_EvaluationLevelMap : EntityTypeConfiguration<Nurse_004_EvaluationLevel>
    {
        public Nurse_004_EvaluationLevelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.EvaluLevel, t.LevelConditionName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EvaluationType)
                .HasMaxLength(50);

            this.Property(t => t.EvaluLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LevelConditionName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedID)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Nurse_004_EvaluationLevel");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.EvaluationType).HasColumnName("EvaluationType");
            this.Property(t => t.EvaluLevel).HasColumnName("EvaluLevel");
            this.Property(t => t.LevelConditionName).HasColumnName("LevelConditionName");
            this.Property(t => t.MinScore).HasColumnName("MinScore");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.ModifiedID).HasColumnName("ModifiedID");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}

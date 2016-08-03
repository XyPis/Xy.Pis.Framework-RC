using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Nurse_001_EvaluationTypeMap : EntityTypeConfiguration<Nurse_001_EvaluationType>
    {
        public Nurse_001_EvaluationTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.EvaluationType, t.EvaluationTypeName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EvaluationType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EvaluationTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedID)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Nurse_001_EvaluationType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.EvaluationTypeID).HasColumnName("EvaluationTypeID");
            this.Property(t => t.EvaluationType).HasColumnName("EvaluationType");
            this.Property(t => t.EvaluationTypeName).HasColumnName("EvaluationTypeName");
            this.Property(t => t.DelFlag).HasColumnName("DelFlag");
            this.Property(t => t.ModifiedID).HasColumnName("ModifiedID");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}

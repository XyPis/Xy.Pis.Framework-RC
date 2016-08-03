using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Nurse_003_EvaluationOptionMap : EntityTypeConfiguration<Nurse_003_EvaluationOption>
    {
        public Nurse_003_EvaluationOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OptionContent)
                .HasMaxLength(500);

            this.Property(t => t.InputType)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedID)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Nurse_003_EvaluationOption");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.EvaluationItemID).HasColumnName("EvaluationItemID");
            this.Property(t => t.OptionContent).HasColumnName("OptionContent");
            this.Property(t => t.OptionScore).HasColumnName("OptionScore");
            this.Property(t => t.InputType).HasColumnName("InputType");
            this.Property(t => t.DelFlag).HasColumnName("DelFlag");
            this.Property(t => t.ModifiedID).HasColumnName("ModifiedID");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}

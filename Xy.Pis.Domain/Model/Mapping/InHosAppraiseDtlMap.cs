using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHosAppraiseDtlMap : EntityTypeConfiguration<InHosAppraiseDtl>
    {
        public InHosAppraiseDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InHosAppraiseDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InHosAppraiseID).HasColumnName("InHosAppraiseID");
            this.Property(t => t.OptionID).HasColumnName("OptionID");
            this.Property(t => t.AppraiseScores).HasColumnName("AppraiseScores");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
        }
    }
}

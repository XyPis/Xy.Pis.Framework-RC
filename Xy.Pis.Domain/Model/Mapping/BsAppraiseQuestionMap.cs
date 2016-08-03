using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsAppraiseQuestionMap : EntityTypeConfiguration<BsAppraiseQuestion>
    {
        public BsAppraiseQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BsAppraiseQuestion");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.BsAppraiseTitleId).HasColumnName("BsAppraiseTitleId");
            this.Property(t => t.LsQuestionType).HasColumnName("LsQuestionType");
            this.Property(t => t.ItemMaxScore).HasColumnName("ItemMaxScore");
        }
    }
}

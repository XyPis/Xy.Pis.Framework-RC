using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsAppraiseOptionMap : EntityTypeConfiguration<BsAppraiseOption>
    {
        public BsAppraiseOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("BsAppraiseOption");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.BsAppraiseQuestionID).HasColumnName("BsAppraiseQuestionID");
            this.Property(t => t.OptionScores).HasColumnName("OptionScores");
            this.Property(t => t.BsAppraiseTitleID).HasColumnName("BsAppraiseTitleID");
            this.Property(t => t.IsInput).HasColumnName("IsInput");
        }
    }
}

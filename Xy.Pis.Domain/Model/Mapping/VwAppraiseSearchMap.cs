using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwAppraiseSearchMap : EntityTypeConfiguration<VwAppraiseSearch>
    {
        public VwAppraiseSearchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InPatNo, t.PatientName, t.AppraiseType, t.HospId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CheckInPlace)
                .HasMaxLength(100);

            this.Property(t => t.AppraiseType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwAppraiseSearch");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CheckInPlace).HasColumnName("CheckInPlace");
            this.Property(t => t.AppraiseScore).HasColumnName("AppraiseScore");
            this.Property(t => t.AppraiseGrade).HasColumnName("AppraiseGrade");
            this.Property(t => t.AppraiseTime).HasColumnName("AppraiseTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.AppraiseType).HasColumnName("AppraiseType");
            this.Property(t => t.HospId).HasColumnName("HospId");
        }
    }
}

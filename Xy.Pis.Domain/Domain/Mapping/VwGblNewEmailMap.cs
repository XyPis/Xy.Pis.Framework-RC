using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwGblNewEmailMap : EntityTypeConfiguration<VwGblNewEmail>
    {
        public VwGblNewEmailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Title, t.Content, t.FileName, t.OperTime, t.OperId, t.IsPriority, t.EmailId, t.UserId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmailId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwGblNewEmail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.ReadTime).HasColumnName("ReadTime");
            this.Property(t => t.HospId).HasColumnName("HospId");
        }
    }
}

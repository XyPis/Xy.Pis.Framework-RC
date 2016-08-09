using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class GblNewEmailUserMap : EntityTypeConfiguration<GblNewEmailUser>
    {
        public GblNewEmailUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GblNewEmailUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.ReadTime).HasColumnName("ReadTime");
            this.Property(t => t.ReadUserId).HasColumnName("ReadUserId");

            // Relationships
            this.HasRequired(t => t.GblNewEmail)
                .WithMany(t => t.GblNewEmailUsers)
                .HasForeignKey(d => d.EmailId);

        }
    }
}

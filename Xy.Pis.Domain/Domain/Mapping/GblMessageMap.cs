using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class GblMessageMap : EntityTypeConfiguration<GblMessage>
    {
        public GblMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MessageContent)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SubmitMan)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("GblMessage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsMessageType).HasColumnName("LsMessageType");
            this.Property(t => t.MessageContent).HasColumnName("MessageContent");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.SubmitMan).HasColumnName("SubmitMan");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
        }
    }
}

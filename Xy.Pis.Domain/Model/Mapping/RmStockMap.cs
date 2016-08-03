using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class RmStockMap : EntityTypeConfiguration<RmStock>
    {
        public RmStockMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RmStock");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasRequired(t => t.BsCompany)
                .WithMany(t => t.RmStocks)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmStocks)
                .HasForeignKey(d => d.RoomId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RmStocks)
                .HasForeignKey(d => d.OperId);

        }
    }
}

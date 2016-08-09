using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class RmStockReqMap : EntityTypeConfiguration<RmStockReq>
    {
        public RmStockReqMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.ApplyIdea)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApplyHander)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RmStockReq");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.ApplyTime).HasColumnName("ApplyTime");
            this.Property(t => t.ValideTime).HasColumnName("ValideTime");
            this.Property(t => t.ApplyIdea).HasColumnName("ApplyIdea");
            this.Property(t => t.ApplyHander).HasColumnName("ApplyHander");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.RmStockReqs)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmStockReqs)
                .HasForeignKey(d => d.RoomId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.RmStockReqs)
                .HasForeignKey(d => d.OperId);

        }
    }
}

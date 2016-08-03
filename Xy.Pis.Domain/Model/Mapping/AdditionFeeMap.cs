using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class AdditionFeeMap : EntityTypeConfiguration<AdditionFee>
    {
        public AdditionFeeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdditionFee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.FeeType).HasColumnName("FeeType");
            this.Property(t => t.Memo).HasColumnName("Memo");

            // Relationships
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.AdditionFees)
                .HasForeignKey(d => d.HospId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.AdditionFees)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.AdditionFees)
                .HasForeignKey(d => d.UnitId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class lmFood1Map : EntityTypeConfiguration<LmFood1>
    {
        public lmFood1Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("lmFoods");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.lsAction).HasColumnName("lsAction");
            this.Property(t => t.Effect).HasColumnName("Effect");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.TimeFrame).HasColumnName("TimeFrame");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
        }
    }
}

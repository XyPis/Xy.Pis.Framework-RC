using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHosAppraiseMap : EntityTypeConfiguration<InHosAppraise>
    {
        public InHosAppraiseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InHosAppraise");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BsAppraiseID).HasColumnName("BsAppraiseID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.EvaluAllScore).HasColumnName("EvaluAllScore");
            this.Property(t => t.EvaluLevelID).HasColumnName("EvaluLevelID");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.AppraiseTime).HasColumnName("AppraiseTime");
        }
    }
}

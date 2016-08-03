using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CoReservationRegeMap : EntityTypeConfiguration<CoReservationRege>
    {
        public CoReservationRegeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FloorName)
                .HasMaxLength(20);

            this.Property(t => t.RoomNo)
                .HasMaxLength(20);

            this.Property(t => t.BedName)
                .HasMaxLength(20);

            this.Property(t => t.ConsultantName)
                .HasMaxLength(30);

            this.Property(t => t.ConsultPhone)
                .HasMaxLength(11);

            this.Property(t => t.ReceptionPerson)
                .HasMaxLength(30);

            this.Property(t => t.HomeAddress)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            this.Property(t => t.PrepayMemo)
                .HasMaxLength(200);

            this.Property(t => t.CancelPrepayMemo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CoReservationRege");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsIntention).HasColumnName("LsIntention");
            this.Property(t => t.PatientSourceCanalId).HasColumnName("PatientSourceCanalId");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.RoomNo).HasColumnName("RoomNo");
            this.Property(t => t.BedName).HasColumnName("BedName");
            this.Property(t => t.ConsultantName).HasColumnName("ConsultantName");
            this.Property(t => t.ConsultPhone).HasColumnName("ConsultPhone");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.ReceptionPerson).HasColumnName("ReceptionPerson");
            this.Property(t => t.HomeAddress).HasColumnName("HomeAddress");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PrepayAmount).HasColumnName("PrepayAmount");
            this.Property(t => t.PrepayMemo).HasColumnName("PrepayMemo");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.CancelPrepayAmount).HasColumnName("CancelPrepayAmount");
            this.Property(t => t.CancelPrepayMemo).HasColumnName("CancelPrepayMemo");
            this.Property(t => t.IsCancelPay).HasColumnName("IsCancelPay");

            // Relationships
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.CoReservationReges)
                .HasForeignKey(d => d.HospId);

        }
    }
}

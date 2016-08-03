using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwPatientInMap : EntityTypeConfiguration<VwPatientIn>
    {
        public VwPatientInMap()
        {
            // Primary Key
            this.HasKey(t => new { t.InPatNo, t.HospNo, t.PatID, t.HospId, t.PatientName, t.Sex, t.NTime, t.SexName, t.LsInStatus, t.IsYbMt, t.PatTypeId });

            // Properties
            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SexName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LsInStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NursingType)
                .HasMaxLength(50);

            this.Property(t => t.AgeString)
                .HasMaxLength(20);

            this.Property(t => t.YearTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwPatientIn");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.MainBedId).HasColumnName("MainBedId");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.IsYbMt).HasColumnName("IsYbMt");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.IsUrgen).HasColumnName("IsUrgen");
            this.Property(t => t.IsNewIn).HasColumnName("IsNewIn");
            this.Property(t => t.NursingType).HasColumnName("NursingType");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.YearTypeName).HasColumnName("YearTypeName");
        }
    }
}

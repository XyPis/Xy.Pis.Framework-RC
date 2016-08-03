using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsPatientMap : EntityTypeConfiguration<BsPatient>
    {
        public BsPatientMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.CardNo)
                .HasMaxLength(19);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.BloodGroup)
                .HasMaxLength(50);

            this.Property(t => t.XNo)
                .HasMaxLength(30);

            this.Property(t => t.Native)
                .HasMaxLength(100);

            this.Property(t => t.Residence)
                .HasMaxLength(100);

            this.Property(t => t.Company)
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .HasMaxLength(20);

            this.Property(t => t.Mobile)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(30);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.Sensitive)
                .HasMaxLength(200);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            this.Property(t => t.MedicareNo)
                .HasMaxLength(18);

            this.Property(t => t.AccountNo)
                .HasMaxLength(13);

            this.Property(t => t.PhoneWork)
                .HasMaxLength(15);

            this.Property(t => t.AddressWork)
                .HasMaxLength(100);

            this.Property(t => t.PostCodeWork)
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeWork)
                .HasMaxLength(5);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(15);

            this.Property(t => t.AddressHome)
                .HasMaxLength(100);

            this.Property(t => t.PostCodeHome)
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeHome)
                .HasMaxLength(5);

            this.Property(t => t.LinkmanName)
                .HasMaxLength(10);

            this.Property(t => t.LinkmanPost)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanArea)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanAddress)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanPhone)
                .HasMaxLength(15);

            this.Property(t => t.SmokeHistory)
                .HasMaxLength(500);

            this.Property(t => t.DrinkHistory)
                .HasMaxLength(500);

            this.Property(t => t.OtherHabit)
                .HasMaxLength(500);

            this.Property(t => t.InActiveReason)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PhotoFolder)
                .HasMaxLength(50);

            this.Property(t => t.PersonHistory)
                .HasMaxLength(500);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.HealthCardNo)
                .HasMaxLength(50);

            this.Property(t => t.HouseholdRegisterAddress)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("BsPatient");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.XNo).HasColumnName("XNo");
            this.Property(t => t.NationId).HasColumnName("NationId");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.RegionId).HasColumnName("RegionId");
            this.Property(t => t.AreaId).HasColumnName("AreaId");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.IsOversea).HasColumnName("IsOversea");
            this.Property(t => t.PassTime).HasColumnName("PassTime");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.CertificateId).HasColumnName("CertificateId");
            this.Property(t => t.Sensitive).HasColumnName("Sensitive");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.isBaby).HasColumnName("isBaby");
            this.Property(t => t.MotherPatId).HasColumnName("MotherPatId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.PhoneWork).HasColumnName("PhoneWork");
            this.Property(t => t.AddressWork).HasColumnName("AddressWork");
            this.Property(t => t.PostCodeWork).HasColumnName("PostCodeWork");
            this.Property(t => t.AreaCodeWork).HasColumnName("AreaCodeWork");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.AreaCodeHome).HasColumnName("AreaCodeHome");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.LinkmanArea).HasColumnName("LinkmanArea");
            this.Property(t => t.LinkmanAddress).HasColumnName("LinkmanAddress");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.FamilyId).HasColumnName("FamilyId");
            this.Property(t => t.isHouseMaster).HasColumnName("isHouseMaster");
            this.Property(t => t.RelaMasterId).HasColumnName("RelaMasterId");
            this.Property(t => t.LsCensus).HasColumnName("LsCensus");
            this.Property(t => t.CommitteeId).HasColumnName("CommitteeId");
            this.Property(t => t.PoliceStationId).HasColumnName("PoliceStationId");
            this.Property(t => t.LevelId).HasColumnName("LevelId");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Circumference).HasColumnName("Circumference");
            this.Property(t => t.Waistline).HasColumnName("Waistline");
            this.Property(t => t.Sternline).HasColumnName("Sternline");
            this.Property(t => t.LsSport).HasColumnName("LsSport");
            this.Property(t => t.LsSportTime).HasColumnName("LsSportTime");
            this.Property(t => t.LsSportType).HasColumnName("LsSportType");
            this.Property(t => t.LsBitHabit).HasColumnName("LsBitHabit");
            this.Property(t => t.SleepHour).HasColumnName("SleepHour");
            this.Property(t => t.LsSleepTrouble).HasColumnName("LsSleepTrouble");
            this.Property(t => t.SmokeHistory).HasColumnName("SmokeHistory");
            this.Property(t => t.DrinkHistory).HasColumnName("DrinkHistory");
            this.Property(t => t.OtherHabit).HasColumnName("OtherHabit");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.PhotoFolder).HasColumnName("PhotoFolder");
            this.Property(t => t.RoadId).HasColumnName("RoadId");
            this.Property(t => t.PersonHistory).HasColumnName("PersonHistory");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.HealthCardNo).HasColumnName("HealthCardNo");
            this.Property(t => t.LsHealthGrade).HasColumnName("LsHealthGrade");
            this.Property(t => t.HouseholdRegisterCityId).HasColumnName("HouseholdRegisterCityId");
            this.Property(t => t.HouseholdRegisterCountyId).HasColumnName("HouseholdRegisterCountyId");
            this.Property(t => t.HouseholdRegisterAddCountyId).HasColumnName("HouseholdRegisterAddCountyId");
            this.Property(t => t.HouseholdRegisterProvinceId).HasColumnName("HouseholdRegisterProvinceId");
            this.Property(t => t.DomicileStreetTownId).HasColumnName("DomicileStreetTownId");
            this.Property(t => t.HouseholdRegisterAddress).HasColumnName("HouseholdRegisterAddress");

            // Relationships
            this.HasOptional(t => t.BsCommitteeRoad)
                .WithMany(t => t.BsPatients)
                .HasForeignKey(d => d.RoadId);
            this.HasOptional(t => t.BsPatient2)
                .WithMany(t => t.BsPatient1)
                .HasForeignKey(d => d.MotherPatId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHosInfoMap : EntityTypeConfiguration<InHosInfo>
    {
        public InHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.HospNo)
                .IsRequired()
                .HasMaxLength(20);

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
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BloodGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Residence)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .HasMaxLength(20);

            this.Property(t => t.YbRegNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(50);

            this.Property(t => t.AddressHome)
                .HasMaxLength(100);

            this.Property(t => t.PostCodeHome)
                .HasMaxLength(7);

            this.Property(t => t.AreaCodeHome)
                .HasMaxLength(5);

            this.Property(t => t.PhoneWork)
                .HasMaxLength(15);

            this.Property(t => t.AddressWork)
                .HasMaxLength(100);

            this.Property(t => t.PostCodeWork)
                .HasMaxLength(50);

            this.Property(t => t.AreaCodeWork)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.LinkmanPhone)
                .HasMaxLength(25);

            this.Property(t => t.LinkmanAddress)
                .HasMaxLength(100);

            this.Property(t => t.LinkmanPost)
                .HasMaxLength(50);

            this.Property(t => t.LinkmanArea)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.AgeString)
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(10);

            this.Property(t => t.FirstLinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.FirstLinkmanIdCard)
                .HasMaxLength(20);

            this.Property(t => t.FirstLinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.FirstLinkmanUnitAddress)
                .HasMaxLength(100);

            this.Property(t => t.FirstLinkmanFamilyAddress)
                .HasMaxLength(100);

            this.Property(t => t.FirstLinkmanFamilyPhone)
                .HasMaxLength(15);

            this.Property(t => t.FirstLinkmanPhone)
                .HasMaxLength(15);

            this.Property(t => t.SecondLinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.SecondLinkmanIdCard)
                .HasMaxLength(20);

            this.Property(t => t.SecondLinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.SecondLinkmanUnitAddress)
                .HasMaxLength(100);

            this.Property(t => t.SecondLinkmanFamilyAddress)
                .HasMaxLength(100);

            this.Property(t => t.SecondLinkmanFamilyPhone)
                .HasMaxLength(15);

            this.Property(t => t.SecondLinkmanPhone)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("InHosInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospNo).HasColumnName("HospNo");
            this.Property(t => t.PatID).HasColumnName("PatID");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.LsMarriage).HasColumnName("LsMarriage");
            this.Property(t => t.BloodGroup).HasColumnName("BloodGroup");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.IsOversea).HasColumnName("IsOversea");
            this.Property(t => t.PassTime).HasColumnName("PassTime");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.WorktypeId).HasColumnName("WorktypeId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.CertificateId).HasColumnName("CertificateId");
            this.Property(t => t.LsInType).HasColumnName("LsInType");
            this.Property(t => t.LsInWay).HasColumnName("LsInWay");
            this.Property(t => t.LsInIllness).HasColumnName("LsInIllness");
            this.Property(t => t.DocMz).HasColumnName("DocMz");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LocIn).HasColumnName("LocIn");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.IsYbMt).HasColumnName("IsYbMt");
            this.Property(t => t.YbRegNo).HasColumnName("YbRegNo");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.AddressHome).HasColumnName("AddressHome");
            this.Property(t => t.PostCodeHome).HasColumnName("PostCodeHome");
            this.Property(t => t.AreaCodeHome).HasColumnName("AreaCodeHome");
            this.Property(t => t.PhoneWork).HasColumnName("PhoneWork");
            this.Property(t => t.AddressWork).HasColumnName("AddressWork");
            this.Property(t => t.PostCodeWork).HasColumnName("PostCodeWork");
            this.Property(t => t.AreaCodeWork).HasColumnName("AreaCodeWork");
            this.Property(t => t.LinkmanName).HasColumnName("LinkmanName");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.LinkmanPhone).HasColumnName("LinkmanPhone");
            this.Property(t => t.LinkmanAddress).HasColumnName("LinkmanAddress");
            this.Property(t => t.LinkmanPost).HasColumnName("LinkmanPost");
            this.Property(t => t.LinkmanArea).HasColumnName("LinkmanArea");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LeaveTime).HasColumnName("LeaveTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsEndChg).HasColumnName("IsEndChg");
            this.Property(t => t.EndChgOperID).HasColumnName("EndChgOperID");
            this.Property(t => t.EndchgoperTime).HasColumnName("EndchgoperTime");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.NursingGradeId).HasColumnName("NursingGradeId");
            this.Property(t => t.FirstLinkmanName).HasColumnName("FirstLinkmanName");
            this.Property(t => t.FirstRelationId).HasColumnName("FirstRelationId");
            this.Property(t => t.FirstLinkmanIdCard).HasColumnName("FirstLinkmanIdCard");
            this.Property(t => t.FirstLinkManWorkUnit).HasColumnName("FirstLinkManWorkUnit");
            this.Property(t => t.FirstLinkmanUnitAddress).HasColumnName("FirstLinkmanUnitAddress");
            this.Property(t => t.FirstLinkmanFamilyAddress).HasColumnName("FirstLinkmanFamilyAddress");
            this.Property(t => t.FirstLinkmanFamilyPhone).HasColumnName("FirstLinkmanFamilyPhone");
            this.Property(t => t.FirstLinkmanPhone).HasColumnName("FirstLinkmanPhone");
            this.Property(t => t.SecondLinkmanName).HasColumnName("SecondLinkmanName");
            this.Property(t => t.SecondRelationId).HasColumnName("SecondRelationId");
            this.Property(t => t.SecondLinkmanIdCard).HasColumnName("SecondLinkmanIdCard");
            this.Property(t => t.SecondLinkManWorkUnit).HasColumnName("SecondLinkManWorkUnit");
            this.Property(t => t.SecondLinkmanUnitAddress).HasColumnName("SecondLinkmanUnitAddress");
            this.Property(t => t.SecondLinkmanFamilyAddress).HasColumnName("SecondLinkmanFamilyAddress");
            this.Property(t => t.SecondLinkmanFamilyPhone).HasColumnName("SecondLinkmanFamilyPhone");
            this.Property(t => t.SecondLinkmanPhone).HasColumnName("SecondLinkmanPhone");
            this.Property(t => t.BedYearTypeId).HasColumnName("BedYearTypeId");
            this.Property(t => t.LsOutManagementType).HasColumnName("LsOutManagementType");
            this.Property(t => t.AddRatioId).HasColumnName("AddRatioId");
            this.Property(t => t.LsEconomicSource).HasColumnName("LsEconomicSource");
            this.Property(t => t.MealTypeId).HasColumnName("MealTypeId");
            this.Property(t => t.ServiceChargeId).HasColumnName("ServiceChargeId");
            this.Property(t => t.AgreementBeginDate).HasColumnName("AgreementBeginDate");
            this.Property(t => t.AgreementEndDate).HasColumnName("AgreementEndDate");
            this.Property(t => t.IsCheckInCharge).HasColumnName("IsCheckInCharge");
            this.Property(t => t.OneTimeFacilityFee).HasColumnName("OneTimeFacilityFee");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.ServiceChargeAmount).HasColumnName("ServiceChargeAmount");
            this.Property(t => t.BedAmount).HasColumnName("BedAmount");
            this.Property(t => t.NursingCost).HasColumnName("NursingCost");

            this.HasRequired(t => t.BedInfo)
               .WithMany(t => t.InHosInfos)
               .HasForeignKey(d => d.BedId);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Vw_GetNewInHosSignContractMap : EntityTypeConfiguration<Vw_GetNewInHosSignContract>
    {
        public Vw_GetNewInHosSignContractMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HospId, t.Name, t.InPatNo, t.HouseRegAddress, t.PresentAddress, t.MealTypePriceIn, t.ServiceChargePriceIn, t.OutManagementType, t.InTime, t.LsMarriageName, t.SelfDrugPriceIn, t.SelfClothesPriceIn, t.SelfNursePriceIn, t.HosRenewId });

            // Properties
            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .HasMaxLength(4);

            this.Property(t => t.InPatNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.AgeString)
                .HasMaxLength(20);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(50);

            this.Property(t => t.HouseRegAddress)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.PresentAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FirstLinkmanName)
                .HasMaxLength(20);

            this.Property(t => t.FirstRelationName)
                .HasMaxLength(50);

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

            this.Property(t => t.SecondRelationName)
                .HasMaxLength(50);

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

            this.Property(t => t.BedRoomTypeName)
                .HasMaxLength(50);

            this.Property(t => t.BedAddress)
                .HasMaxLength(100);

            this.Property(t => t.BedYearTypeName)
                .HasMaxLength(50);

            this.Property(t => t.NursingGradeName)
                .HasMaxLength(50);

            this.Property(t => t.MealTypePriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceChargePriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OutManagementType)
                .IsRequired()
                .HasMaxLength(22);

            this.Property(t => t.LsMarriageName)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Native)
                .HasMaxLength(100);

            this.Property(t => t.EduLevel)
                .HasMaxLength(50);

            this.Property(t => t.SelfDrugPriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SelfClothesPriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SelfNursePriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhoneHome)
                .HasMaxLength(50);

            this.Property(t => t.HosRenewId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EatingHabits)
                .HasMaxLength(100);

            this.Property(t => t.MealTypeOtherMemo)
                .HasMaxLength(100);

            this.Property(t => t.ChargeNotice)
                .HasMaxLength(100);

            this.Property(t => t.OtherLanguages)
                .HasMaxLength(100);

            this.Property(t => t.OtherServices)
                .HasMaxLength(100);

            this.Property(t => t.PersonalPreference)
                .HasMaxLength(100);

            this.Property(t => t.ServicePhysicalCondition)
                .HasMaxLength(100);

            this.Property(t => t.OtherExplain)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_GetNewInHosSignContract");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.IsCheckInAgree).HasColumnName("IsCheckInAgree");
            this.Property(t => t.IsPurchaseCost).HasColumnName("IsPurchaseCost");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.AgeString).HasColumnName("AgeString");
            this.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            this.Property(t => t.HouseRegAddress).HasColumnName("HouseRegAddress");
            this.Property(t => t.PresentAddress).HasColumnName("PresentAddress");
            this.Property(t => t.FirstLinkmanName).HasColumnName("FirstLinkmanName");
            this.Property(t => t.FirstRelationName).HasColumnName("FirstRelationName");
            this.Property(t => t.FirstLinkmanIdCard).HasColumnName("FirstLinkmanIdCard");
            this.Property(t => t.FirstLinkManWorkUnit).HasColumnName("FirstLinkManWorkUnit");
            this.Property(t => t.FirstLinkmanUnitAddress).HasColumnName("FirstLinkmanUnitAddress");
            this.Property(t => t.FirstLinkmanFamilyAddress).HasColumnName("FirstLinkmanFamilyAddress");
            this.Property(t => t.FirstLinkmanFamilyPhone).HasColumnName("FirstLinkmanFamilyPhone");
            this.Property(t => t.FirstLinkmanPhone).HasColumnName("FirstLinkmanPhone");
            this.Property(t => t.SecondLinkmanName).HasColumnName("SecondLinkmanName");
            this.Property(t => t.SecondRelationName).HasColumnName("SecondRelationName");
            this.Property(t => t.SecondLinkmanIdCard).HasColumnName("SecondLinkmanIdCard");
            this.Property(t => t.SecondLinkManWorkUnit).HasColumnName("SecondLinkManWorkUnit");
            this.Property(t => t.SecondLinkmanUnitAddress).HasColumnName("SecondLinkmanUnitAddress");
            this.Property(t => t.SecondLinkmanFamilyAddress).HasColumnName("SecondLinkmanFamilyAddress");
            this.Property(t => t.SecondLinkmanFamilyPhone).HasColumnName("SecondLinkmanFamilyPhone");
            this.Property(t => t.SecondLinkmanPhone).HasColumnName("SecondLinkmanPhone");
            this.Property(t => t.BedRoomTypeName).HasColumnName("BedRoomTypeName");
            this.Property(t => t.BedAddress).HasColumnName("BedAddress");
            this.Property(t => t.BedYearTypeName).HasColumnName("BedYearTypeName");
            this.Property(t => t.NursingGradeName).HasColumnName("NursingGradeName");
            this.Property(t => t.BedRoomTypePriceIn).HasColumnName("BedRoomTypePriceIn");
            this.Property(t => t.MealTypePriceIn).HasColumnName("MealTypePriceIn");
            this.Property(t => t.NursingGradePriceIn).HasColumnName("NursingGradePriceIn");
            this.Property(t => t.ServiceChargePriceIn).HasColumnName("ServiceChargePriceIn");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.OutManagementType).HasColumnName("OutManagementType");
            this.Property(t => t.OneLifeFacFee).HasColumnName("OneLifeFacFee");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.LsMarriageName).HasColumnName("LsMarriageName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Native).HasColumnName("Native");
            this.Property(t => t.EduLevel).HasColumnName("EduLevel");
            this.Property(t => t.AgreementBeginDate).HasColumnName("AgreementBeginDate");
            this.Property(t => t.AgreementEndDate).HasColumnName("AgreementEndDate");
            this.Property(t => t.SelfDrugPriceIn).HasColumnName("SelfDrugPriceIn");
            this.Property(t => t.SelfClothesPriceIn).HasColumnName("SelfClothesPriceIn");
            this.Property(t => t.SelfNursePriceIn).HasColumnName("SelfNursePriceIn");
            this.Property(t => t.PhoneHome).HasColumnName("PhoneHome");
            this.Property(t => t.HosRenewId).HasColumnName("HosRenewId");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.IsRoomFloor).HasColumnName("IsRoomFloor");
            this.Property(t => t.EatingHabits).HasColumnName("EatingHabits");
            this.Property(t => t.MealTypeOtherMemo).HasColumnName("MealTypeOtherMemo");
            this.Property(t => t.ChargeNotice).HasColumnName("ChargeNotice");
            this.Property(t => t.IsCantonese).HasColumnName("IsCantonese");
            this.Property(t => t.IsMandarin).HasColumnName("IsMandarin");
            this.Property(t => t.OtherLanguages).HasColumnName("OtherLanguages");
            this.Property(t => t.OtherServices).HasColumnName("OtherServices");
            this.Property(t => t.PersonalPreference).HasColumnName("PersonalPreference");
            this.Property(t => t.ServicePhysicalCondition).HasColumnName("ServicePhysicalCondition");
            this.Property(t => t.OtherExplain).HasColumnName("OtherExplain");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.CancelOperTime).HasColumnName("CancelOperTime");
        }
    }
}

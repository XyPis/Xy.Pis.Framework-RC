using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Vw_InHosSignContractMap : EntityTypeConfiguration<Vw_InHosSignContract>
    {
        public Vw_InHosSignContractMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .HasMaxLength(2);

            this.Property(t => t.InPatNo)
                .HasMaxLength(30);

            this.Property(t => t.AgeString)
                .HasMaxLength(10);

            this.Property(t => t.IdCardNo)
                .HasMaxLength(30);

            this.Property(t => t.HouseRegAddress)
                .HasMaxLength(200);

            this.Property(t => t.PresentAddress)
                .HasMaxLength(200);

            this.Property(t => t.FirstLinkmanName)
                .HasMaxLength(30);

            this.Property(t => t.FirstRelationName)
                .HasMaxLength(30);

            this.Property(t => t.FirstLinkmanIdCard)
                .HasMaxLength(30);

            this.Property(t => t.FirstLinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.FirstLinkmanUnitAddress)
                .HasMaxLength(200);

            this.Property(t => t.FirstLinkmanFamilyAddress)
                .HasMaxLength(200);

            this.Property(t => t.FirstLinkmanFamilyPhone)
                .HasMaxLength(50);

            this.Property(t => t.FirstLinkmanPhone)
                .HasMaxLength(11);

            this.Property(t => t.SecondLinkmanName)
                .HasMaxLength(30);

            this.Property(t => t.SecondRelationName)
                .HasMaxLength(30);

            this.Property(t => t.SecondLinkmanIdCard)
                .HasMaxLength(30);

            this.Property(t => t.SecondLinkManWorkUnit)
                .HasMaxLength(100);

            this.Property(t => t.SecondLinkmanUnitAddress)
                .HasMaxLength(200);

            this.Property(t => t.SecondLinkmanFamilyAddress)
                .HasMaxLength(200);

            this.Property(t => t.SecondLinkmanFamilyPhone)
                .HasMaxLength(50);

            this.Property(t => t.SecondLinkmanPhone)
                .HasMaxLength(30);

            this.Property(t => t.BedRoomTypeName)
                .HasMaxLength(30);

            this.Property(t => t.BedAddress)
                .HasMaxLength(100);

            this.Property(t => t.BedYearTypeName)
                .HasMaxLength(60);

            this.Property(t => t.NursingGradeName)
                .HasMaxLength(60);

            this.Property(t => t.OutManagementType)
                .HasMaxLength(30);

            this.Property(t => t.LsMarriageName)
                .HasMaxLength(10);

            this.Property(t => t.Native)
                .HasMaxLength(100);

            this.Property(t => t.EduLevel)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_InHosSignContract");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.HosRenewId).HasColumnName("HosRenewId");
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
            this.Property(t => t.IsExpire).HasColumnName("IsExpire");
            this.Property(t => t.BedId).HasColumnName("BedId");
            this.Property(t => t.BedYearTypeId).HasColumnName("BedYearTypeId");
            this.Property(t => t.SelfDrugPriceIn).HasColumnName("SelfDrugPriceIn");
            this.Property(t => t.SelfClothesPriceIn).HasColumnName("SelfClothesPriceIn");
            this.Property(t => t.SelfNursePriceIn).HasColumnName("SelfNursePriceIn");
            this.Property(t => t.RenewBeginTime).HasColumnName("RenewBeginTime");
            this.Property(t => t.RenewEndTime).HasColumnName("RenewEndTime");
            this.Property(t => t.IsSendRenewMessage).HasColumnName("IsSendRenewMessage");
            this.Property(t => t.Selected).HasColumnName("Selected");
        }
    }
}

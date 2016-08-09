using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InHosInfoRenewMap : EntityTypeConfiguration<InHosInfoRenew>
    {
        public InHosInfoRenewMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OutBedAddress)
                .HasMaxLength(100);

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
            this.ToTable("InHosInfoRenew");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperRenewId).HasColumnName("OperRenewId");
            this.Property(t => t.OperRenewTime).HasColumnName("OperRenewTime");
            this.Property(t => t.Frequency).HasColumnName("Frequency");
            this.Property(t => t.OutBedAddress).HasColumnName("OutBedAddress");
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
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.InRenewOldId).HasColumnName("InRenewOldId");
            this.Property(t => t.BedAmount).HasColumnName("BedAmount");
            this.Property(t => t.NursingCost).HasColumnName("NursingCost");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.InHosInfoRenews)
                .HasForeignKey(d => d.OperRenewId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.InHosInfoRenews)
                .HasForeignKey(d => d.HospId);

        }
    }
}

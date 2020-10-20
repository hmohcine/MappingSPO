using MappingSPO.Entities;

namespace MappingSPO
{
    public class SysRelationsParaEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysRelationsParaEntity>
    {
        public SysRelationsParaEntityConfiguration()
            : this("Settings")
        {
        }

        public SysRelationsParaEntityConfiguration(string schema)
        {
            ToTable("tsysRelationsPara", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RelationType).HasColumnName(@"RelationType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MasterType).HasColumnName(@"MasterType").HasColumnType("int").IsOptional();
            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsOptional();
            Property(x => x.RelationTypeId).HasColumnName(@"RelationTypeID").HasColumnType("int").IsOptional();
            Property(x => x.Code1Caption).HasColumnName(@"Code1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code2Caption).HasColumnName(@"Code2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code3Caption).HasColumnName(@"Code3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code4Caption).HasColumnName(@"Code4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code5Caption).HasColumnName(@"Code5Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code6Caption).HasColumnName(@"Code6Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code7Caption).HasColumnName(@"Code7Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Code8Caption).HasColumnName(@"Code8Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsCode1Caption).HasColumnName(@"ADSCode1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsCode2Caption).HasColumnName(@"ADSCode2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsCode3Caption).HasColumnName(@"ADSCode3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsCode4Caption).HasColumnName(@"ADSCode4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsRef1Caption).HasColumnName(@"ADSRef1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsRef2Caption).HasColumnName(@"ADSRef2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsRef3Caption).HasColumnName(@"ADSRef3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsRef4Caption).HasColumnName(@"ADSRef4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AdsGuid).HasColumnName(@"ADSGuid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Ref1Caption).HasColumnName(@"Ref1Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref2Caption).HasColumnName(@"Ref2Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref3Caption).HasColumnName(@"Ref3Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.Ref4Caption).HasColumnName(@"Ref4Caption").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsCode1Caption1).HasColumnName(@"EmmaADSCode1Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsCode2Caption1).HasColumnName(@"EmmaADSCode2Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsCode3Caption1).HasColumnName(@"EmmaADSCode3Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsCode4Caption1).HasColumnName(@"EmmaADSCode4Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsRef1Caption1).HasColumnName(@"EmmaADSRef1Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsRef2Caption1).HasColumnName(@"EmmaADSRef2Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsRef3Caption1).HasColumnName(@"EmmaADSRef3Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.EmmaAdsRef4Caption1).HasColumnName(@"EmmaADSRef4Caption1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropText01Label).HasColumnName(@"ExtraPropText01Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropText02Label).HasColumnName(@"ExtraPropText02Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropText03Label).HasColumnName(@"ExtraPropText03Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropText04Label).HasColumnName(@"ExtraPropText04Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropNum01Label).HasColumnName(@"ExtraPropNum01Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropNum02Label).HasColumnName(@"ExtraPropNum02Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropNum03Label).HasColumnName(@"ExtraPropNum03Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.ExtraPropNum04Label).HasColumnName(@"ExtraPropNum04Label").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.TranslationMasterSwitch).HasColumnName(@"TranslationMasterSwitch").HasColumnType("bit").IsOptional();
            Property(x => x.StockmanagedbyEmma).HasColumnName(@"StockmanagedbyEmma").HasColumnType("bit").IsOptional();
            Property(x => x.ShowBAnacode1).HasColumnName(@"ShowBAnacode1").HasColumnType("bit").IsOptional();
            Property(x => x.LabelBAnaCode1).HasColumnName(@"LabelBAnaCode1").HasColumnType("nvarchar").IsOptional().HasMaxLength(35);
            Property(x => x.AnaModeValues).HasColumnName(@"AnaModeValues").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.AnaModeDefaultValue).HasColumnName(@"AnaModeDefaultValue").HasColumnType("int").IsOptional();
            Property(x => x.ActiviteitDelimeterChar).HasColumnName(@"ActiviteitDelimeterChar").HasColumnType("nvarchar").IsOptional().HasMaxLength(1);
            Property(x => x.CompanyWebUrl).HasColumnName(@"CompanyWebUrl").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CompanyWebLogon).HasColumnName(@"CompanyWebLogon").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CompanyWebPassword).HasColumnName(@"CompanyWebPassword").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.UseNewRelationScreen).HasColumnName(@"UseNewRelationScreen").HasColumnType("bit").IsRequired();
        }
    }
}

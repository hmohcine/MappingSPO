using MappingSPO.Project.DL.Entities;

namespace MappingSPO.Project.DL.Configurations
{
    public class CalcTypeEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CalcTypeEntity>
    {
        public CalcTypeEntityConfiguration()
            : this("Settings")
        {
        }

        public CalcTypeEntityConfiguration(string schema)
        {
            ToTable("tCalcType", schema);
            HasKey(x => x.CalcTypeId);

            Property(x => x.CalcTypeId).HasColumnName(@"CalcTypeID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CalcMayorTypeCode).HasColumnName(@"CalcMayorTypeCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.CalcType_).HasColumnName(@"CalcType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CalcTypeDescription).HasColumnName(@"CalcTypeDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(250);
            Property(x => x.ArticleLibraryType).HasColumnName(@"ArticleLibraryType").HasColumnType("int").IsOptional();
            Property(x => x.ArticleLibraryId).HasColumnName(@"ArticleLibraryID").HasColumnType("bigint").IsOptional();
            Property(x => x.ArticleLibrarySettings).HasColumnName(@"ArticleLibrarySettings").HasColumnType("int").IsOptional();
            Property(x => x.PostLibraryType).HasColumnName(@"PostLibraryType").HasColumnType("int").IsOptional();
            Property(x => x.PostLibraryId).HasColumnName(@"PostLibraryID").HasColumnType("bigint").IsOptional();
            Property(x => x.PostLibrarySettings).HasColumnName(@"PostLibrarySettings").HasColumnType("int").IsOptional();
            Property(x => x.SetOfferDateToDay).HasColumnName(@"SetOfferDateToDay").HasColumnType("bit").IsOptional();
            Property(x => x.PostDontOverwrite).HasColumnName(@"PostDontOverwrite").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultCalcName).HasColumnName(@"DefaultCalcName").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.ExcludeFromAutoBackup).HasColumnName(@"ExcludeFromAutoBackup").HasColumnType("bit").IsOptional();
            Property(x => x.WinstMode).HasColumnName(@"WinstMode").HasColumnType("int").IsOptional();
            Property(x => x.Disabled).HasColumnName(@"Disabled").HasColumnType("bit").IsRequired();
            Property(x => x.AutoFillCalculatorWithOwner).HasColumnName(@"AutoFillCalculatorWithOwner").HasColumnType("bit").IsOptional();
            Property(x => x.Domain).HasColumnName(@"Domain").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.DefaultCalcSoort).HasColumnName(@"DefaultCalcSoort").HasColumnType("int").IsRequired();
            Property(x => x.PostLibraryIncludeQuantities).HasColumnName(@"PostLibraryIncludeQuantities").HasColumnType("bit").IsOptional();
            Property(x => x.DefaultVerkoopCatId).HasColumnName(@"DefaultVerkoopCatID").HasColumnType("bigint").IsOptional();
        }
    }
}

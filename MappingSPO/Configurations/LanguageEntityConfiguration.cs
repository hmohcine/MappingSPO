using MappingSPO.Entities;

namespace MappingSPO
{
    public class LanguageEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LanguageEntity>
    {
        public LanguageEntityConfiguration()
            : this("Settings")
        {
        }

        public LanguageEntityConfiguration(string schema)
        {
            ToTable("tLanguage", schema);
            HasKey(x => x.Code);

            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Language_).HasColumnName(@"Language").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ExterneCode).HasColumnName(@"ExterneCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }
}

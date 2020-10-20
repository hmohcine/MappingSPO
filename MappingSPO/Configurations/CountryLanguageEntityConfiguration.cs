using MappingSPO.Entities;

namespace MappingSPO
{
    public class CountryLanguageEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CountryLanguageEntity>
    {
        public CountryLanguageEntityConfiguration()
            : this("Settings")
        {
        }

        public CountryLanguageEntityConfiguration(string schema)
        {
            ToTable("tCountryLanguage", schema);
            HasKey(x => new { x.CountryCode, x.Code });

            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);

            HasRequired(a => a.Country_CountryCode).WithMany(b => b.CountryLanguages).HasForeignKey(c => c.CountryCode);
            HasRequired(a => a.Language).WithMany(b => b.CountryLanguages).HasForeignKey(c => c.Code).WillCascadeOnDelete(false);
        }
    }
}

using MappingSPO.Entities;

namespace MappingSPO
{
    public class CountriesLinkDataEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CountriesLinkDataEntity>
    {
        public CountriesLinkDataEntityConfiguration()
            : this("Settings")
        {
        }

        public CountriesLinkDataEntityConfiguration(string schema)
        {
            ToTable("tCountries_LinkData", schema);
            HasKey(x => new { x.Source, x.CountryCode });

            Property(x => x.Source).HasColumnName(@"Source").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ExternalId).HasColumnName(@"ExternalId").HasColumnType("bigint").IsOptional();

            HasRequired(a => a.Country).WithMany(b => b.CountriesLinkDatas).HasForeignKey(c => c.CountryCode);
        }
    }
}

using MappingSPO.Entities;

namespace MappingSPO
{
    public class CountryEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CountryEntity>
    {
        public CountryEntityConfiguration()
            : this("Settings")
        {
        }

        public CountryEntityConfiguration(string schema)
        {
            ToTable("tCountrys", schema);
            HasKey(x => x.CountryCode);

            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Country_).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Activated).HasColumnName(@"Activated").HasColumnType("bit").IsOptional();
            Property(x => x.Nationality).HasColumnName(@"Nationality").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ExterneCode1).HasColumnName(@"ExterneCode1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ExterneCode2).HasColumnName(@"ExterneCode2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsoCode2).HasColumnName(@"IsoCode2").HasColumnType("nvarchar").IsOptional().HasMaxLength(2);
            Property(x => x.IsoCode3).HasColumnName(@"IsoCode3").HasColumnType("nvarchar").IsOptional().HasMaxLength(3);
        }
    }
}

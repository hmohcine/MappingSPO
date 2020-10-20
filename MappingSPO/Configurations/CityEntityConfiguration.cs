using MappingSPO.Entities;

namespace MappingSPO
{
    public class CityEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CityEntity>
    {
        public CityEntityConfiguration()
            : this("Settings")
        {
        }

        public CityEntityConfiguration(string schema)
        {
            ToTable("tCitys", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ZipCode).HasColumnName(@"ZipCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.City_).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.CountryCode).HasColumnName(@"CountryCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(4);
            Property(x => x.RegioId).HasColumnName(@"RegioID").HasColumnType("bigint").IsOptional();

            HasOptional(a => a.Country).WithMany(b => b.Cities).HasForeignKey(c => c.CountryCode).WillCascadeOnDelete(false);
            HasOptional(a => a.Region).WithMany(b => b.Cities).HasForeignKey(c => c.RegioId).WillCascadeOnDelete(false);
        }
    }
}

using MappingSPO.Entities;

namespace MappingSPO
{
    public class RegionEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RegionEntity>
    {
        public RegionEntityConfiguration()
            : this("Settings")
        {
        }

        public RegionEntityConfiguration(string schema)
        {
            ToTable("tRegion", schema);
            HasKey(x => x.RegioId);

            Property(x => x.RegioId).HasColumnName(@"RegioID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Regio).HasColumnName(@"Regio").HasColumnType("nvarchar").IsOptional().HasMaxLength(150);
        }
    }
}

using MappingSPO.Entities;

namespace MappingSPO
{
    public class ExternalApiSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ExternalApiSettingEntity>
    {
        public ExternalApiSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public ExternalApiSettingEntityConfiguration(string schema)
        {
            ToTable("tExternalAPISetting", schema);
            HasKey(x => x.Id);

            Property(x => x.Source).HasColumnName(@"Source").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Key).HasColumnName(@"Key").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyID").HasColumnType("int").IsOptional();
        }
    }
}

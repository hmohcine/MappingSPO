using MappingSPO.Entities;

namespace MappingSPO
{
    public class CodaBoxSettingEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CodaBoxSettingEntity>
    {
        public CodaBoxSettingEntityConfiguration()
            : this("Settings")
        {
        }

        public CodaBoxSettingEntityConfiguration(string schema)
        {
            ToTable("tCodaBoxSettings", schema);
            HasKey(x => x.SettingName);

            Property(x => x.SettingName).HasColumnName(@"SettingName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SettingValue).HasColumnName(@"SettingValue").HasColumnType("nvarchar(max)").IsRequired();
        }
    }
}

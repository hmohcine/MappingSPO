using MappingSPO.Entities;

namespace MappingSPO
{
    public class ActiviteitGpsLinkDataEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ActiviteitGpsLinkDataEntity>
    {
        public ActiviteitGpsLinkDataEntityConfiguration()
            : this("Settings")
        {
        }

        public ActiviteitGpsLinkDataEntityConfiguration(string schema)
        {
            ToTable("tActiviteit_GPSLinkData", schema);
            HasKey(x => x.ActiviteitId);

            Property(x => x.ActiviteitId).HasColumnName(@"ActiviteitID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ActiviteitKey).HasColumnName(@"ActiviteitKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.ExternalKey).HasColumnName(@"ExternalKey").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsRequired();
        }
    }
}

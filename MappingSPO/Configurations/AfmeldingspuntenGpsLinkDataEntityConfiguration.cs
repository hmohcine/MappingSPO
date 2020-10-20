using MappingSPO.Entities;

namespace MappingSPO
{
    public class AfmeldingspuntenGpsLinkDataEntityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AfmeldingspuntenGpsLinkDataEntity>
    {
        public AfmeldingspuntenGpsLinkDataEntityConfiguration()
            : this("Settings")
        {
        }

        public AfmeldingspuntenGpsLinkDataEntityConfiguration(string schema)
        {
            ToTable("tAfmeldingspunten_GPSLinkData", schema);
            HasKey(x => x.AfmpuntId);

            Property(x => x.AfmpuntId).HasColumnName(@"AfmpuntID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AfmpuntKey).HasColumnName(@"AfmpuntKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.ExternalKey).HasColumnName(@"ExternalKey").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsRequired();
        }
    }
}
